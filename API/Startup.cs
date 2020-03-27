using API.Extensions;
using API.Features;
using API.Interfaces;
using API.NewFolder;
using Core.SSO;
//using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenTheDoor.Models;
using OpenTheDoor.SSO;

namespace API
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
                options.AddPolicy(Policies.all_access, policy => policy.Requirements.Add(new AllAccessRequirement()));
                options.AddPolicy(Policies.authentication_access, policy => policy.Requirements.Add(new AuthAccessRequirement()));
                //options.AddPolicy(Policies.OnlyThirdParties, policy => policy.Requirements.Add(new OnlyThirdPartiesRequirement()));
            });
            //services.AddScoped<ApiKeyAuthenticationHandler, InMemoryApiKeyManager>();
            //services.AddSingleton<IAuthorizationHandler, OnlyEmployeesAuthorizationHandler>();
            //services.AddSingleton<IAuthorizationHandler, OnlyServicesAuthorizationHandler>();
            services.AddSingleton<IAuthorizationHandler, AuthAccessAuthorizationHandler>();
            services.AddSingleton<IAuthorizationHandler, AllAccessAuthorizationHandler>();
            //services.AddSingleton<IAuthorizationHandler, OnlyServicesAuthorizationHandler>();
            //services.AddSingleton<IAuthorizationHandler, OnlyThirdPartiesAuthorizationHandler>();
            services.AddScoped<IApiKeyManager, InMemoryApiKeyManager>();



            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = ApiKeyAuthenticationOptions.DefaultScheme;
                options.DefaultChallengeScheme = ApiKeyAuthenticationOptions.DefaultScheme;
            }).AddApiKeySupport(options => { });


            services.AddDbContext<SSOContext>(options =>

              options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("API")));


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
