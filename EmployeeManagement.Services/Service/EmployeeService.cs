using EmployeeManagement.DataAccess.DataModels;
using EmployeeManagement.Repository.IRepository;
using EmployeeManagement.Services.IService;

namespace EmployeeManagement.Services.Service;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }
    public async Task<List<Employee>> GetEmployeeList()
    {
        return await _employeeRepository.GetAllEmployees();
    }

    public async Task Create(Employee employee)
    {
        await _employeeRepository.AddEmployee(employee);
    }
    public async Task<Employee> Details(int id)
    {
        return await _employeeRepository.GetEmployeeData(id);
    }

    public async Task Edit(Employee employee)
    {
        await _employeeRepository.UpdateEmployee(employee);
    }
    public async Task Delete(int id)
    {
        await _employeeRepository.DeleteEmployee(id);
    }
    public async Task<List<City>> GetCities()
    {
        return await _employeeRepository.GetCityData();
    }
    public async Task<List<Department>> GetDepartments()
    {
        return await _employeeRepository.GetDepartmentData();
    }
}
