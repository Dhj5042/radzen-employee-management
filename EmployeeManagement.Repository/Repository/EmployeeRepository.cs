using EmployeeManagement.DataAccess;
using EmployeeManagement.DataAccess.DataModels;
using EmployeeManagement.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Formats.Asn1;

namespace EmployeeManagement.Repository.Repository;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly ApplicationDbcontext _dbContext;

    public EmployeeRepository(ApplicationDbcontext dbContext)
    {
        _dbContext = dbContext;
    }

    // To get all employees' details, including related City and Department data
    public async Task<List<Employee>> GetAllEmployees()
    {
        return await _dbContext.Employee
            .Include(e => e.City)           // Include related City data
            .Include(e => e.Department)     // Include related Department data
            .ToListAsync();
    }

    // To add a new employee record
    public async Task AddEmployee(Employee employee)
    {
       await _dbContext.Employee.AddAsync(employee);
       await _dbContext.SaveChangesAsync();
    }

    // To update the records of a particular employee
    public async Task UpdateEmployee(Employee employee)
    {
        _dbContext.Entry(employee).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();
    }

    // Get the details of a particular employee, including related City and Department data
    public async Task<Employee> GetEmployeeData(int id)
    {
        return await _dbContext.Employee
            .Include(e => e.City)
            .Include(e => e.Department)
            .FirstOrDefaultAsync(e => e.EmployeeId == id);
    }

    // To delete the record of a particular employee
    public async Task DeleteEmployee(int id)
    {
        var employee = await _dbContext.Employee.FirstOrDefaultAsync(x=>x.EmployeeId == id);
        if (employee != null)
        {
            _dbContext.Employee.Remove(employee);
            _dbContext.SaveChangesAsync();
        }
    }

    // To get the list of Cities
    public async Task<List<City>> GetCityData()
    {
        return await _dbContext.Cities.ToListAsync();
    }

    // To get the list of Departments
    public async Task<List<Department>> GetDepartmentData()
    {
        return await _dbContext.Departments.ToListAsync();
    }
}
