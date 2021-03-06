using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlueSkyTravel.Models;
using BlueSkyTravel.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using BlueSkyTravel.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using BlueSkyTravel.Areas.IdentityModel;
using BlueSkyTravel.Models.IdentityModel;

namespace BlueSkyTravel
{
    public class Startup
    {
        private string googleClientId = null;
        private string googleClientSecret = null;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc(options =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .Build();

            });

            services.AddDbContext<BlueSkyContext>();
            services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<BlueSkyContext>()
            .AddDefaultTokenProviders();
            
            services.AddControllersWithViews();
            services.AddRazorPages().AddRazorRuntimeCompilation();

            services.AddAuthentication();
                //.AddGoogle(googleOptions =>
                //{
                //    IConfigurationSection googleAuthNSection =
                //Configuration.GetSection("Authentication:Google");

                //    googleOptions.ClientId = googleAuthNSection["ClientId"];
                //    googleOptions.ClientSecret = googleAuthNSection["ClientSecret"];
                //})
                //.AddTwitter(twitterOptions => 
                //{
                //    twitterOptions.ConsumerKey = Configuration["Authentication:Twitter:ConsumerAPIKey"];
                //    twitterOptions.ConsumerSecret = Configuration["Authentication:Twitter:ConsumerSecret"];
                //    twitterOptions.RetrieveUserDetails = true;
                //})
                //.AddFacebook(facebookOptions => 
                //{
                //    facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                //    facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
                //});

       
            services.AddScoped<IRepository<Itinerary>, ItineraryRepository>();
            services.AddScoped<IRepository<ForFun>, ForFunRepository>();
            services.AddScoped<IRepository<Hotel>, HotelRepository>();
            services.AddScoped<IRepository<Flight>, FlightRepository>();
        }


            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                    app.UseDatabaseErrorPage();
                }
                else
                {
                    app.UseExceptionHandler("/Home/Error");
                    app.UseHsts();
                }
                app.UseHttpsRedirection();
                app.UseStaticFiles();

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
}
