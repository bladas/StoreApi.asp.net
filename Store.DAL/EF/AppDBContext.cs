using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Store.DAL.Entities;

namespace Store.DAL.EF
{
    public class AppDBContext : IdentityDbContext<User>
    {
       
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
           .ToTable("Product");

            modelBuilder.Entity<Category>()
               .HasKey(p => p.Id);
           
              
            modelBuilder.Entity<Product>()
                .HasOne<Category>(c => c.Category)
                .WithMany(t => t.Products)
                .HasForeignKey(c => c.CategoryId);
           
            modelBuilder.Entity<Category>().HasData(new Category[] {
                new Category{Id=1,NameCategory="Ноутбуки" },
                new Category{Id=2,NameCategory="Телефони" },
                new Category{Id=3,NameCategory="Комп'ютери" },
               
            });
        }
    }
}

