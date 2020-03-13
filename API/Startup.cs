﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoorAPI.Extensions;
using DoorAPI.Features;
using DoorAPI.Handlers;
using DoorAPI.Interfaces;
using DoorAPI.NewFolder;
//using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenTheDoor.Models;

namespace DoorAPI
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

            services.AddAuthorization(options =>
            {
                //options.AddPolicy(Policies.OnlyEmployees, policy => policy.Requirements.Add(new OnlyEmployeesRequirement()));
                options.AddPolicy(Policies.OnlyServices, policy => policy.Requirements.Add(new OnlyServicesRequirement()));
                //options.AddPolicy(Policies.OnlyThirdParties, policy => policy.Requirements.Add(new OnlyThirdPartiesRequirement()));
            });
            //services.AddScoped<ApiKeyAuthenticationHandler, InMemoryApiKeyManager>();
            //services.AddSingleton<IAuthorizationHandler, OnlyEmployeesAuthorizationHandler>();
            //services.AddSingleton<IAuthorizationHandler, OnlyServicesAuthorizationHandler>();
            services.AddSingleton<IAuthorizationHandler, OnlyServicesAuthorizationHandler>();
            //services.AddSingleton<IAuthorizationHandler, OnlyServicesAuthorizationHandler>();
            //services.AddSingleton<IAuthorizationHandler, OnlyThirdPartiesAuthorizationHandler>();



            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = ApiKeyAuthenticationOptions.DefaultScheme;
                options.DefaultChallengeScheme = ApiKeyAuthenticationOptions.DefaultScheme;
            }).AddApiKeySupport(options => { });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.EnvironmentName == "dev")
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            //app.UseHsts();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            //app.UseHttpsRedirection();

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});
        }
    }
}