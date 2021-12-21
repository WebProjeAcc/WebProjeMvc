using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebProje.Data;
using WebProje.Models;

[assembly: HostingStartup(typeof(WebProje.Areas.Identity.IdentityHostingStartup))]
namespace WebProje.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DbContextConnection")));

                services.AddIdentity<Users, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddDefaultTokenProviders()
                .AddDefaultUI()
                .AddEntityFrameworkStores<AppDbContext>();

                services.Configure<IdentityOptions>(options =>
                {
                    options.Password.RequireDigit = true;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequiredLength = 3;


                }
                );
                
            });
        }
    }
}