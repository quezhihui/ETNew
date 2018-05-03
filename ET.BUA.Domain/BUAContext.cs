using ET.BUA.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace ET.BUA.Domain
{
    public class BUAContext : DbContext
    {
        public virtual DbSet<ApplicationEntity> app { get; set; }

        public BUAContext(DbContextOptions<BUAContext> options) : base(options)
        {

        }
    }
}
