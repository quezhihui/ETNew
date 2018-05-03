using ET.Core.Abstraction.Repo;
using ET.BUA.Entity.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ET.BUA.Domain.Repository.Implementation
{
    public class ApplicationRepository : BaseRepository<ApplicationEntity>,IApplicationRepository
    {
        private readonly BUAContext _context;

        public ApplicationRepository(BUAContext context) : base(context)
        {
            _context = context;
        }
    }

}