using EmployeeManagement.DataAccess.DataModels;
using EmployeeManagement.Repository.IRepository;
using EmployeeManagement.Services.IService;

namespace EmployeeManagement.Services.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> AuthenticateAsync(string username, string password)
        {
            var user = await _userRepository.AuthenticateAsync(username, password);

            if (user == null)
                return null;

            return user;
        }
    }
}
