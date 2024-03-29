﻿using Business.Implementations;
using Business.Interfaces;
using Core;
using Core.Entities;
using Data.DAL;
using Data.Repositories;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.ViewModels.ProductSize;
using Business.ViewModels.Slider;
using Microsoft.AspNetCore.Http;

namespace LifeStyle
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
            services.AddControllersWithViews()
                .AddFluentValidation(p =>
                    p.RegisterValidatorsFromAssemblyContaining<ProductBrandCreateViewModel>()
                );
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:Default"]);
            });
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(Options =>
            {
                Options.Password.RequiredLength = 8;
                Options.Password.RequireNonAlphanumeric = false;
                Options.Password.RequireLowercase = false;
                Options.Password.RequireUppercase = false;
                Options.Password.RequireDigit = true;


                Options.User.AllowedUserNameCharacters = "abcçdeəfgğhiıjklmnopqrsştuüvyzxqwWABCÇDEƏFGĞHİIJKLMNOPQRSŞTUÜVYZXQ0123456789-._ ";
            });
            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = new PathString("/Error_404");
            });
            services.AddAuthentication().AddFacebook(options =>
            {
                options.AppId = "679373123404159";
                options.AppSecret = "b2f94211c8b1d4cc3ab06b19e65b42de";
            });
            services.AddAuthentication().AddGoogle(options =>
            {
                options.ClientId = "910103900779-31m21f00r9pirt6fnjs3b63rbja3ehf5.apps.googleusercontent.com";
                options.ClientSecret = "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";
            });
            services.AddAuthentication().AddTwitter(options =>
            {
                options.ConsumerKey = "4xKCmlg4miT3SkO44ND5CS06e";
                options.ConsumerSecret = "Zq41BHnQ1dvlWBmklWCGVmtWUTSM4qwddxBHdxr1CNVQE3DCS7";
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IGenderCategoryService, GenderCategoryService>();
            services.AddScoped<IProductCategoryService, ProductCategoryService>();
            services.AddScoped<IProductColorService, ProductColorService>();
            services.AddScoped<IProductImageService, ProductImageService>();
            services.AddScoped<IProductBrandService, ProductSizeService>();
            services.AddScoped<ISliderService, SliderService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ISaleService, SaleService>();
            services.AddScoped<IProductBFOSService, ProductBFOSService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=SuperHome}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
