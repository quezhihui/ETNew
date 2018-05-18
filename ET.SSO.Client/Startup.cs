using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IdentityModel.Tokens.Jwt;

namespace ET.SSO.Client
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = "Cookies";
                options.DefaultChallengeScheme = "oidc";
            }).AddCookie("Cookies").AddOpenIdConnect("oidc", options =>
            {
                options.SignInScheme = Configuration["SSO:SignInScheme"];
                options.Authority = Configuration["SSO:Authority"];
                options.RequireHttpsMetadata = Configuration["SSO:RequireHttpsMetadata"] == "false" ? false : true;
                options.ClientId = Configuration["SSO:ClientId"];
                options.ClientSecret = Configuration["SSO:ClientSecret"];
                options.ResponseType = Configuration["SSO:ResponseType"];
                options.SaveTokens = Configuration["SSO:SaveTokens"] == "false" ? false : true;
                options.GetClaimsFromUserInfoEndpoint = Configuration["SSO:GetClaimsFromUserInfoEndpoint"] == "false" ? false : true;
                options.Scope.Add(Configuration["SSO:APIid"]);
                options.Scope.Add(Configuration["SSO:AccessType"]);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseAuthentication();

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
