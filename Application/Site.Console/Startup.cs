using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using EZNEW.Web.Mvc;
using EZNEW.Web.Mvc.Display;
using EZNEW.Web.Mvc.Validation;
using EZNEW.Web.Security.Authorization;
using AppConfig.IoC;
using Site.Console.Controllers;
using Site.Console.Util;
using Site.Console.Filters;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using EZNEW.Diagnostics;

namespace Site.Console
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            ContainerFactory.RegisterServices(services);
            services.AddHttpContextAccessor();
            services.AddLogging(cfg =>
            {
                cfg.AddTraceSource("eznew", new DefaultTraceListener());
                cfg.AddFilter("microsoft", LogLevel.Warning);
            });
            SwitchManager.EnableFrameworkTrace();
            services.AddMvc(options =>
            {
                options.ModelValidatorProviders.Add(new CustomDataAnnotationsModelValidatorProvider());
                options.ModelMetadataDetailsProviders.Add(new CustomModelDisplayProvider());
                options.Filters.Add<ExtendAuthorizeFilter>();
                options.Filters.Add<ConsoleExceptionFilter>();
            })
            .AddViewOptions(vo =>
            {
                vo.ClientModelValidatorProviders.Add(new CustomDataAnnotationsClientModelValidatorProvider());
            })
            .AddRazorOptions(ro =>
            {
                ro.ViewLocationExpanders.Add(new FolderLevelViewLocationExpander(typeof(WebBaseController)));
            });
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
            .AddCookieAuthentication(option =>
            {
                option.ForceValidatePrincipal = true;
                option.ValidatePrincipalAsync = IdentityManager.ValidatePrincipalAsync;
                option.CookieConfiguration = options =>
                {
                    options.LoginPath = "/login";
                    options.AccessDeniedPath = "/accessdenied";
                };
            });
            var serviceProvider = ContainerFactory.GetServiceProvider();
            return serviceProvider;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "accessdenied",
                    template: "accessdenied",
                    defaults: new { controller = "account", action = "AccessDenied" });
                routes.MapRoute(
                    name: "login",
                    template: "login",
                    defaults: new { controller = "account", action = "login" });
                routes.MapRoute(
                    name: "loginout",
                    template: "loginout",
                    defaults: new { controller = "account", action = "LoginOut" });
                routes.MapRoute(
                    name: "noauth",
                    template: "noauth",
                    defaults: new { controller = "home", action = "authentication" });
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            SiteConfig.Init();
        }
    }
}
