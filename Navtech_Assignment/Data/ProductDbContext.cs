using Microsoft.EntityFrameworkCore;
using Navtech_Assignment.Models;

namespace Navtech_Assignment.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options): base(options)
        { }

        public DbSet<Product> Product { get; set; }


    }
}
