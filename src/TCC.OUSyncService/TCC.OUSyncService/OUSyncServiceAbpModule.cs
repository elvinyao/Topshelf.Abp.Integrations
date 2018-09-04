using System.Reflection;
using Abp.Modules;
using Topshelf.Quartz.Abp;

namespace TCC.OUSyncService
{
    [DependsOn(typeof(TopshelfQuartzAbpModule))]
    public class OUSyncServiceAbpModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }


    //EF DbContext class.
}