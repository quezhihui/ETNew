using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using ET.Core.Abstraction.Uow;
using ET.BUA.Domain;
using ET.BUA.Web.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;

namespace ET.BUA.Web
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        public IContainer Container { get; private set; }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BUAContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("BUAConnection")));
            services.AddUnitOfWork<BUAContext>();
            services.AddRouting(options => options.LowercaseUrls = true);

            services.AddMvc().AddControllersAsServices();

            var builder = new ContainerBuilder();

            builder.RegisterModule(new RepositoryModule());

            builder.RegisterModule(new ServiceModule());

            builder.Populate(services);

            return new AutofacServiceProvider(builder.Build());
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, BUAContext dbcontext, IApplicationLifetime appLifetime)
        {
            //同一日志中间件需要最先引入，方法全程记录全局日志
            #region 记录日志默认方法
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            #endregion

            #region Serilog日志插件配置

            loggerFactory.AddDebug((className, logLevel) =>
            {
                if (className.StartsWith("ET.BUA."))
                    return true;
                return false;
            });

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .MinimumLevel.Override("ET.BUA", Serilog.Events.LogEventLevel.Debug)
                .Enrich.FromLogContext()
                .WriteTo.LiterateConsole()
                .WriteTo.Seq("http://172.28.10.82:5341")
                .CreateLogger();

            loggerFactory.AddSerilog();
            appLifetime.ApplicationStopped.Register(Log.CloseAndFlush);
            #endregion

            #region 跨域请求配置
            //1.域 AllowAnyOrigin()  WithOrigins()
            //2.方法 AllowAnyMethod() WithMethods()
            //3.请求头AllowAnyHeader() WithHeaders()
            //4.设置暴露的响应头 WithExposedHeaders()
            #region 1.设置允许的域
            //允许一个或多个请求的域
            app.UseCors(builder =>
            {
                builder.WithOrigins("http://desktop.dongjiangoa.com", "http://document.dongjiangoa.com")
                .AllowAnyHeader().AllowAnyMethod();
            });
            //允许所有的域
            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            });
            #endregion

            #region 2.设置允许的HTTP方法
            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin().AllowAnyHeader().WithMethods("POST", "GET", "HEAD");
            });
            #endregion

            #region 3.设置允许请求头
            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin().WithHeaders("accept", "content-type", "origin", "x-custom-header").AllowAnyMethod();
            });
            #endregion

            #region 4.设置暴露的响应头
            /*默认情况下，浏览器并不暴露所有的响应头，默认可用的响应头如下所示：
            Cache - Control
            Content - Language
            Content - Type
            Expires
            Last - Modified
            Pragma*/
            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin().WithExposedHeaders("x-custom-header");
            });
            #endregion

            #endregion

            #region 开发-生产环境设置切换
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            #endregion

            #region StaticFiles 中间件
            app.UseStaticFiles();
            #endregion

            #region MVC路由设置

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=App}/{action=AppAdd}/{id?}");
            });

            #endregion

            #region 数据初始化
            DbInitializer.Initialize(dbcontext);
            #endregion

            #region 配置默认请求响应
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
            #endregion

            appLifetime.ApplicationStopped.Register(() => this.Container.Dispose());
        }
    }
}
