using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebProjesi.Areas.Identity.Data;
using WebProjesi.Data;

[assembly: HostingStartup(typeof(WebProjesi.Areas.Identity.IdentityHostingStartup))]
namespace WebProjesi.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WebProjesiContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WebProjesiContextConnection")));

                services.AddDefaultIdentity<WebProjesiKullanici>(options => {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequiredLength = 3;
                    }
                ).AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<WebProjesiContext>();
            });
        }
    }
}