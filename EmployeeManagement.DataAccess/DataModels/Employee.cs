using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.DataAccess.DataModels;

public class Employee
{
    public int EmployeeId { get; set; }

    [StringLength(50, MinimumLength = 3)]
    public string FirstName { get; set; }

    [StringLength(50, MinimumLength = 3)]
    public string LastName { get; set; }

    public string Email { get; set; }

    [StringLength(20, MinimumLength = 3)]
    public string Gender { get; set; } = string.Empty;

    public DateTime? DateOfBirth { get; set; }

    public int DepartmentId { get; set; }  // Foreign Key
    public Department? Department { get; set; }  // Navigation Property

    public int? CityId { get; set; }  // Foreign Key
    public City City { get; set; }  // Navigation Property

    public DateTime? DateOfJoining { get; set; }
    public decimal? Salary { get; set; }

    public string PhoneNumber { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
}

