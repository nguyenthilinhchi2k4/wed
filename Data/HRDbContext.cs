using HRManagementApp.Models;
using Microsoft.EntityFrameworkCore;
namespace HRManagementApp.Data;
public class HRDbContext : DbContext
{
    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }

    public HRDbContext(DbContextOptions<HRDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>()
            .ToTable("Department_Tbl");

        modelBuilder.Entity<Employee>()
            .ToTable("Employee_Tbl");
    }
}
