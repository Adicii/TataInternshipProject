using ProductApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProductApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=OracleDbContext")
        {
            Database.SetInitializer<AppDbContext>(null);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<SoftwareMetrics> SoftwareMetrics { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) 
        {
            modelBuilder.HasDefaultSchema("SYSTEM");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<SoftwareMetrics>().ToTable("SOFTWARE_METRICS");  

            base.OnModelCreating(modelBuilder);
        }
    }
}
