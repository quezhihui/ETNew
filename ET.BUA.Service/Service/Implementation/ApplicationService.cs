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
    public class ApplicationService : IApplicationService
    {
        private readonly IApplicationRepository _appRepo;
        private readonly IUnitOfWork _unitOfWork;

        public ApplicationService(
            IApplicationRepository appRepo,
            IUnitOfWork unitOfWork)
        {
            _appRepo = appRepo ?? throw new ArgumentNullException(nameof(appRepo));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public void Add(ApplicationEntity app)
        {
            _appRepo.Insert(app);
            _unitOfWork.SaveChanges();
        }

        public async Task<ApplicationEntity> GetSingleModelAsync(string Code)
        {
            return await _appRepo.FirstOrDefaultAsync(c => c.APP_CODE==Code);
        }

        public ApplicationEntity GetSingleModel(string Code)
        {
            return  _appRepo.FirstOrDefault(c => c.APP_CODE == Code);
        }
    }
}