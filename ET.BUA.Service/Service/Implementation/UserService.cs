using ET.Core.Abstraction.Uow;
using ET.BUA.Domain.Repository;
using ET.BUA.Entity.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET.BUA.Service.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(
            IUserRepository userRepo,
            IUnitOfWork unitOfWork)
        {
            _userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public async Task<UserEntity> Find(string useruid, string password)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("USER_UID", useruid);
            dic.Add("USER_PASSWD", password);
            return await _userRepo.FindAsync(dic);
        }

        public UserEntity FindByUserUID(string useruid)
        {
            return _userRepo.FirstOrDefault(x => x.USER_UID.Equals(useruid, StringComparison.OrdinalIgnoreCase));
        }

        public bool ValidateCredentials(string useruid, string password)
        {
            var user = FindByUserUID(useruid);
            if (user != null)
            {
                return user.USER_PASSWD.Equals(password);
            }
            return false;
        }
    }
}