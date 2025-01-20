using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;

namespace ProductAPI
{

    public class ProductsDbContext:DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
