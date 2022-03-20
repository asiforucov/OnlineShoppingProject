using Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Data.Configurations;

namespace Data.DAL
{
    public class AppDbContext : IdentityDbContext<ApplicationUser> 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new GenderCategoryConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
            builder.ApplyConfiguration(new ProductCategoryConfiguration());
            builder.ApplyConfiguration(new ProductColorConfiguration());
            builder.ApplyConfiguration(new ProductImageConfiguration());
            builder.ApplyConfiguration(new ProductBrandConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new SliderConfiguration());
          
            base.OnModelCreating(builder);
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<GenderCategory> GenderCategory { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductColor> ProductColor { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<ProductOperation> ProductOperations { get; set; }
    }
}
