using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using ET.BUA.Domain;
using ET.BUA.Entity.Model;
using ET.SSO.IdentityServer4.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;

namespace ET.SSO.IdentityServer4
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


           


            //IdentityServer配置
            services.AddIdentityServer()
                .AddDeveloperSigningCredential()
                .AddInMemoryIdentityResources(Config.GetIdentityResources())
                .AddInMemoryApiResources(Config.GetApiResources())
                .AddInMemoryClients(Config.GetClients());
            //.AddAspNetIdentity<UserEntity>();


            //Autofac配置
            var builder = new ContainerBuilder();

            builder.RegisterModule(new RepositoryModule());

            builder.RegisterModule(new ServiceModule());

            builder.Populate(services);

            return new AutofacServiceProvider(builder.Build());
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IApplicationLifetime appLifetime)
        {

            //同一日志中间件需要最先引入，方法全程记录全局日志
            #region 记录日志默认方法
            //loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            //loggerFactory.AddDebug();
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

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseIdentityServer();

            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();
        }
    }
}
