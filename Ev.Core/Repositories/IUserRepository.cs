using Ev.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetAsync(Guid id);
        Task<User> GetAsync(string email);
        Task AddSync(User user);
        Task UpdateAsync(User user);
        Task DeletAsync(User user);
    }
}
