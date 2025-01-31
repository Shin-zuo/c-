using InventoryMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryMVC.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
