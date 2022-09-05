using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }
        public DbSet<EmployeeModel> employees { get; set; }
        public DbSet<DepartmentModel> departments { get; set; }
        public DbSet<OrganisationModel> organisations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganisationModel>()
                .HasMany<DepartmentModel>(a => a.Department)
                .WithOne(s => s.OrganisationModel)
                .HasForeignKey(s => s.Id);
            modelBuilder.Entity<DepartmentModel>()
                .HasMany<EmployeeModel>(a => a.Employees)
                .WithOne(s => s.Department)
                .HasForeignKey(s => s.DepId);
            base.OnModelCreating(modelBuilder);
        }


    }
}
