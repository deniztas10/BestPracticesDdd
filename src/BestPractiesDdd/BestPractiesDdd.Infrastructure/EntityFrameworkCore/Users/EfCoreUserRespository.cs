using BestPractiesDdd.Domain.Domains.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestPractiesDdd.Infrastructure.EntityFrameworkCore.Users
{
    public class EfCoreUserRespository : IUserRepository
    {

        private readonly EfCoreDbContext _dbContext;
        public EfCoreUserRespository(EfCoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> Get(Guid id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x=>x.Id == id);
        }

        public async Task<List<User>> GetUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task Update(User user)
        {
            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();
        }
    }
}
