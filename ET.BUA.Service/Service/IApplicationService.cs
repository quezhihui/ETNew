using ET.BUA.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ET.BUA.Service.Service
{
    public interface IApplicationService
    {
        void Add(ApplicationEntity app);

        Task<ApplicationEntity> GetSingleModelAsync(string Code);

        ApplicationEntity GetSingleModel(string Code);
    }
}
