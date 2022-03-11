using Microsoft.EntityFrameworkCore;
using NorthwindProject.API.Models.DB.Entities;

namespace NorthwindProject.API.Models.DB.Context
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Northwind;uid=sa;pwd=123");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<User> User { get; set; }
    }
}
