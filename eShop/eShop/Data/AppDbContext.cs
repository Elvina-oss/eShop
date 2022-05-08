using eShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category_Perfume>().HasKey(am => new
            {
                am.CategoryId,
                am.PerfumeId
            });
            modelBuilder.Entity<Category_Perfume>().HasOne(m => m.Perfume).WithMany(am => am.Category_Perfumes).HasForeignKey(
                m => m.PerfumeId);
            modelBuilder.Entity<Category_Perfume>().HasOne(m => m.Category).WithMany(am => am.Category_Perfumes).HasForeignKey(
                m => m.CategoryId);
            base.OnModelCreating(modelBuilder);
       
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category_Perfume> Category_Perfumes { get; set; }
        public DbSet<Perfume> Perfumes { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
