using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using WebProje.Data;
using WebProje.Models;
using Microsoft.EntityFrameworkCore;
using WebProje.Areas.Identity.Data;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

namespace WebProje
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
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc().AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();
            services.AddDbContext<AppDbContext>(options =>
                   options.UseSqlServer(
                       Configuration.GetConnectionString("DbContextConnection")));

            services.AddIdentity<Users, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddDefaultTokenProviders()
            .AddDefaultUI()
            .AddEntityFrameworkStores<AppDbContext>();

            services.AddControllersWithViews();
          
            services.AddRazorPages();

            services.AddControllersWithViews();

            services.AddScoped<IDbInitializer, DbInitializer>();
            services.AddDbContext<DatabaseContext>();
            services.Configure<RequestLocalizationOptions>(
           options =>
           {
               var supportedCultures = new List<CultureInfo>
                   {
                        new CultureInfo("en-US"),
                        new CultureInfo("tr-TR")
                   };

               options.DefaultRequestCulture = new RequestCulture(culture: "tr-TR", uiCulture: "tr-TR");
               options.SupportedCultures = supportedCultures;
               options.SupportedUICultures = supportedCultures;

               options.RequestCultureProviders.Insert(0, new QueryStringRequestCultureProvider());
           });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IDbInitializer dbInitializer)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            dbInitializer.Initialize();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
