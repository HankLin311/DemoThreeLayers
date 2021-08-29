using Microsoft.EntityFrameworkCore;
using DemoThreeLayers.Common.Entities;

namespace RehabusSystem.Common.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 設定 Key
            modelBuilder.Entity<Employee>()
                .HasKey(employee => new { employee.EmployeeId, employee.IdentityNumber });
        }
    }
}
