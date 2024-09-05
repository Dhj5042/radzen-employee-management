using EmployeeManagement.DataAccess.DataModels;

namespace EmployeeManagement.Repository.IRepository
{
    public interface IUserRepository
    {
        Task<User> AuthenticateAsync(string username, string password);
    }
}
