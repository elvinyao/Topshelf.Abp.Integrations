using System.Data.Entity;
using Abp.EntityFramework;
using TCC.OUSyncService.Entities;

namespace TCC.OUSyncService
{
    public class OUSyncAppDbContext : AbpDbContext
    {
        public virtual IDbSet<TccEmployee> TccEmployees { get; set; }
        public virtual IDbSet<TccOrgnization> TccOrgnizations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public OUSyncAppDbContext()
            : base("Default")
        {
        }

        public OUSyncAppDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }
    }
}