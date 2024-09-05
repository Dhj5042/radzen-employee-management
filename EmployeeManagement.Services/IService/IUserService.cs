using EmployeeManagement.DataAccess.DataModels;

namespace EmployeeManagement.Services.IService
{
    public interface IUserService
    {
        Task<User> AuthenticateAsync(string username, string password);
    }
}
