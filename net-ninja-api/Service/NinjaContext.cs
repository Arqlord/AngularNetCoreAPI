using Microsoft.EntityFrameworkCore;

namespace net_ninja_api.Service
{
    public class NinjaContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public NinjaContext(DbContextOptions<NinjaContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
    
    
}
