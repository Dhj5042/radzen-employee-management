using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.DataAccess;

public class ApplicationDbcontext : DbContext
{
    public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
    {

    }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>()
            .HasOne(e => e.Department) // Relationship between Employee and Department
            .WithMany(d => d.Employees) // One department can have many employees
            .HasForeignKey(e => e.DepartmentId); // Foreign key on DepartmentId
    }
}
