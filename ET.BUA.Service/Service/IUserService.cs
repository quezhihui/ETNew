using ET.BUA.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ET.BUA.Service.Service
{
    public interface IUserService
    {
        Task<UserEntity> Find(string useruid, string password);

        bool ValidateCredentials(string useruid, string password);

        UserEntity FindByUserUID(string useruid);
    }
}
