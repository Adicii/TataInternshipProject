using ProductApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProductApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=OracleDbContext")
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("SYSTEM");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Department>().ToTable("Department");

            base.OnModelCreating(modelBuilder);
        }
    }
}
