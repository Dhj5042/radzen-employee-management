using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.DataAccess.DataModels;

public class Department
{
    public int DepartmentId { get; set; }

    [StringLength(100)]
    public string DepartmentName { get; set; }

    public ICollection<Employee> Employees { get; set; }  // Navigation Property
}
