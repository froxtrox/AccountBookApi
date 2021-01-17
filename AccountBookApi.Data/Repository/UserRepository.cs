using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AccountBookApi.Data.Repository.Interfaces;
using AccountBookApi.Domain;
namespace AccountBookApi.Data.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AccountBookDBContext context) : base(context)
        {
        }
    }
}