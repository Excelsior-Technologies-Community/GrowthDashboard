using GrowthDashboard.Models;
using Microsoft.EntityFrameworkCore;

namespace GrowthDashboard.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ChartPoint> ChartPoints { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ChartPoint>().HasNoKey();
        }
    }
}
