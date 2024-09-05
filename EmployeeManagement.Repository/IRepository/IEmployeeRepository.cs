using EmployeeManagement.DataAccess.DataModels;

namespace EmployeeManagement.Repository.IRepository;

public interface IEmployeeRepository
{
    Task AddEmployee(Employee employee);
    Task DeleteEmployee(int id);
    Task<List<Employee>> GetAllEmployees();
    Task<List<City>> GetCityData();
    Task<Employee> GetEmployeeData(int id);
    Task UpdateEmployee(Employee employee);
    Task<List<Department>> GetDepartmentData();
}
