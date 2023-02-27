﻿using Ev.Core.Domain;
using Ev.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static readonly ISet<User> _users = new HashSet<User>();

        public async Task<User> GetAsync(Guid id)
        => await Task.FromResult(_users.SingleOrDefault(x => x.Id == id));

        public async Task<User> GetAsync(string email)
        => await Task.FromResult(_users.SingleOrDefault(x => x.Email.ToLowerInvariant() == email.ToLowerInvariant()));

        public async Task AddSync(User user)
        {
            _users.Add(user);
            await Task.CompletedTask;  
        }
        public async Task UpdateAsync(User user)
        {
            await Task.CompletedTask;
        }
        public async Task DeletAsync(User user)
        {
            _users.Remove(user);
            await Task.CompletedTask;
        }

       

        
    }
}
