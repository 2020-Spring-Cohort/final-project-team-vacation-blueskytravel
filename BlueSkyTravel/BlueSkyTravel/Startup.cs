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
using BlueSkyTravel.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using BlueSkyTravel.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;



namespace BlueSkyTravel
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
            services.AddIdentity<IdentityUser, IdentityRole>();

            services.AddMvc(options =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .Build();

            });

            services.AddDbContext<UserDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews();
            
            services.AddTransient<IMailService, SendGridMailService>();

            services.AddRazorPages();

            services.AddAuthentication()
                .AddGoogle(options =>
                {
                    options.ClientId = "470608566033-l6stb5m97m52e2gj4o0lks736adr9t9i.apps.googleusercontent.com";
                    options.ClientSecret = "zKiwibQf-MSCGbLqWiOtPNKJ";
                })
                .AddFacebook(options =>
                {
                    options.AppId = "245899396584726";
                    options.AppSecret = "e1f242444c49e759d19eeaab94dc2e0a";
                })
                .AddTwitter(options =>
                {
                    options.ConsumerKey = "fMMpNfnH3oDzdXSJ0fq558fow";
                    options.ConsumerSecret = "cBeCunIByEJzrQuf42jWmDRcYMCoJARUhb4ARRcj6TDmDG2kmI";
                    options.RetrieveUserDetails = true;
                });
            services.AddDbContext<BlueSkyContext>();
            services.AddScoped<IRepository<Itinerary>, ItineraryRepository>();
            services.AddScoped<IRepository<ForFun>, ForFunRepository>();
            services.AddScoped<IRepository<Hotel>, HotelRepository>();
            services.AddScoped<IRepository<Flight>, FlightRepository>();
            services.AddScoped<IRepository<Vote>, VoteRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
