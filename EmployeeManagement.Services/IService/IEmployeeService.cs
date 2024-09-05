using EmployeeManagement.DataAccess.DataModels;

namespace EmployeeManagement.Services.IService;

public interface IEmployeeService
{
    Task Create(Employee employee);
    Task Delete(int id);
    Task<Employee> Details(int id);
    Task Edit(Employee employee);
    Task<List<City>> GetCities();
    Task<List<Employee>> GetEmployeeList();
    Task<List<Department>> GetDepartments();
}
