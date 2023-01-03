using Microsoft.EntityFrameworkCore;

namespace WiredBrainCoffeeAdmin.Data {
    public class WiredContext : DbContext 
    {
        public WiredContext(DbContextOptions<WiredContext> options) : base(options) 
        {
            
        } 
        public DbSet<Product> Products { get; set; } 
    }
}
