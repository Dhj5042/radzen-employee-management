using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.DataAccess.DataModels;

public class City
{
    public int CityId { get; set; }

    [StringLength(100)]
    public string CityName { get; set; }

    public ICollection<Employee> Employees { get; set; }  // Navigation Property
}