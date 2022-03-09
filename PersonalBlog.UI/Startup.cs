using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using PersonalBlog.UI.BackgroundServices;
using PersonalBlog.UI.DIExtensions;
using PersonalBlog.UI.EmailControl;
using PersonalBlog.UI.FileControl;
using PersonalBlog.UI.Mapping;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.UI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLocalization(opt => { opt.ResourcesPath = "Resources"; });
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(240);
                options.Cookie.Name = "apUser";
            });
            services.AddMvc()
               .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
               .AddDataAnnotationsLocalization(options =>
               {
                   options.DataAnnotationLocalizerProvider = (type, factory) =>
                   factory.Create(typeof(SharedResource));
               });
            services.Configure<RequestLocalizationOptions>(
              opt =>
              {
                  var supportedCultures = new List<CultureInfo>
                  {
                        new CultureInfo("tr"),
                        new CultureInfo("en"),
                  };
                  opt.DefaultRequestCulture = new RequestCulture("tr");
                  opt.SupportedCultures = supportedCultures;
                  opt.SupportedUICultures = supportedCultures;
              }
              );
            services.AddControllersWithViews().AddFluentValidation(p=>p.RegisterValidatorsFromAssemblyContaining<Startup>());
            services.AddHostedService<ContactMailService>();
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddDataAccessLayer();
            services.AddBusinessLogicLayer();
            services.AddScoped<IEmail, Email>();
            services.AddScoped<IFileControlService, FileControlManager>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseRequestLocalization(app.ApplicationServices.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "areaDefault",
                   pattern: "{area:exists}/{controller=Home}/{action=Login}/{id?}"
                   );
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
