using Core.Entities;
using DAL.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ComboDetail>().HasKey(cd => new { cd.ComboId, cd.ProductId });
            modelBuilder.Entity<OrderDetail>().HasKey(od => new { od.OrderId, od.ItemId });
        }

        public DbSet<Product> Products { get; }
        public DbSet<Combo> Combos { get; }
        public DbSet<ComboDetail> ComboDetails { get; }
        public DbSet<Customer> Customers { get; }
        public DbSet<Order> Orders { get; }
        public DbSet<OrderDetail> OrderDetails { get; }
        public DbSet<Storage> Storages { get; }
    }
}
