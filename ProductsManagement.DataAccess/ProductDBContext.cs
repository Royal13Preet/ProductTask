using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProductsManagement.DataAccess.DBmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagement.DataAccess
{
    public class ProductDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
       
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "bottle",
                    Price = 67
                });
        }
        
    }
}
