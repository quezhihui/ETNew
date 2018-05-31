using ET.BUA.Entity.Model;
using ET.Core.Abstraction.Repo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ET.BUA.Domain.Repository.Implementation
{
    public class UserRepository : BaseRepository<UserEntity>, IUserRepository
    {
        private readonly BUAContext _context;

        public UserRepository(BUAContext context) : base(context)
        {
            _context = context;
        }
    }
}
