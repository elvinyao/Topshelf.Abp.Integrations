//namespace TCC.OUSyncService
//{
//    using System;
//    using System.Data.Entity;
//    using System.ComponentModel.DataAnnotations.Schema;
//    using System.Linq;

//    public partial class OUManagementData : DbContext
//    {
//        public OUManagementData()
//            : base("name=OUManagementData")
//        {
//        }

//        public virtual DbSet<TccEmployees> TccEmployees { get; set; }
//        public virtual DbSet<TccOrgnizations> TccOrgnizations { get; set; }

//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<TccOrgnizations>()
//                .HasMany(e => e.TccEmployees)
//                .WithRequired(e => e.TccOrgnizations)
//                .HasForeignKey(e => e.OrgnizationBelongedId);
//        }
//    }
//}
