//// File: Data/ECommerceDbContext.cs
//using Microsoft.EntityFrameworkCore;

//namespace ECommerceAPI.Data
//{
//    public class ECommerceDbContext : DbContext
//    {
//        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options)
//            : base(options)
//        {
//        }

//        // DbSets will be added here
//    }
//}

using ECommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Data
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options)
            : base(options)
        {
        }

        //public DbSet<User> Users { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Global Query Filter for Soft Delete
            modelBuilder.Entity<User>().HasQueryFilter(u => !u.IsDeleted);
            modelBuilder.Entity<Product>().HasQueryFilter(p => !p.IsDeleted);

        }
    }
}
