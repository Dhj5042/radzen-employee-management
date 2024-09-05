using EmployeeManagement.DataAccess;
using EmployeeManagement.DataAccess.DataModels;
using EmployeeManagement.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repository.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbcontext _dbContext;

        public UserRepository(ApplicationDbcontext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<User> AuthenticateAsync(string username,string password)
        {
            return await _dbContext.Users.SingleOrDefaultAsync(x => x.Username == username);
        }

    }
}
