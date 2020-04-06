
using eCommNet.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace eCommNet.Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) {}
        
        public DbSet<Product> Products { get; set; }
    }
}