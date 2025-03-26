using Ecommerce.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Ecommerce.ProductService.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) 
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 1, Name = "Shirt", Price = 20, Quantity = 10 });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 2, Name = "Pant", Price = 100, Quantity = 20 });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 3, Name = "Polo", Price = 200, Quantity = 5 });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ProductModel> Products { get; set; }
    }
}
