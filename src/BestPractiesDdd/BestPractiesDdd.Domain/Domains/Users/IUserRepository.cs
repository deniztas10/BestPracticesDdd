using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestPractiesDdd.Domain.Domains.Users
{
    public interface IUserRepository
    {

        Task<User> Get(Guid id);

        Task Update(User user);

        Task<List<User>> GetUsers();
    }
}
