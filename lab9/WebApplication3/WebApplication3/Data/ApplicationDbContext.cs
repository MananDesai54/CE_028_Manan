using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CustomerProduct>().HasKey(sc => new { sc.CustomerId, sc.ProductId, sc.Order_date });
            modelBuilder.Entity<CustomerProduct>()
            .Property(b => b.Order_date)
            .HasDefaultValueSql("CONVERT(date, GETDATE())");
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerProduct> CustomerProduct { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
