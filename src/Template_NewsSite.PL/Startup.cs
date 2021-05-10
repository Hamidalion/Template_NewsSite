using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_NewsSite.PL.Domain.Context;
using Template_NewsSite.PL.Domain.Managers;
using Template_NewsSite.PL.Domain.Repository.EntityFramework;
using Template_NewsSite.PL.Domain.Repository.Interfaces;
using Template_NewsSite.PL.Services;

namespace Template_NewsSite.PL
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // add our owned apsettings.json file in Startup.sc
            Configuration.Bind("Project", new Config());

            // add new functional app as like as servises
            services.AddTransient<ITextFieldRepository, EFTextFieldRepository>();
            services.AddTransient<INewsItemRepository, EFNewsItemRepository>();
            services.AddTransient<DataManager>();

            // add database context
            services.AddDbContext<NewsSiteDbContext>(x => x.UseSqlServer(Config.ConnectionString));

            // tune Identity
            services.AddIdentity<IdentityUser, IdentityRole>(ops =>
            {
                ops.User.RequireUniqueEmail = true;
                ops.Password.RequiredLength = 6;
                ops.Password.RequireNonAlphanumeric = false;
                ops.Password.RequireLowercase = false;
                ops.Password.RequireUppercase = false;
                ops.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<NewsSiteDbContext>().AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(option =>
            {
                option.Cookie.Name = "NewsCompanyAuth";
                option.Cookie.HttpOnly = true;
                option.LoginPath = "/account/login";
                option.AccessDeniedPath = "/account/accessdenied";
                option.SlidingExpiration = true;
            });

            // add seporting Controllers and views
            services.AddControllersWithViews()
                // set version of asp.net
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // show errors if app has development level
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // add sistem routing 
            app.UseRouting();

            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            // usingn stating file as CSS,JS,img and etc.
            app.UseStaticFiles();

            // register new start point
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
