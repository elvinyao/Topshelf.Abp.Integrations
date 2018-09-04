using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp;
using Quartz;
using Topshelf;
using Topshelf.Quartz;
using Topshelf.Quartz.Abp;

namespace TCC.OUSyncService
{
    class Program
    {
        static int Main(string[] args)
        {
            using (var bootstrapper = new AbpBootstrapper())
            {
                bootstrapper.Initialize();

                return (int) HostFactory.Run(x =>
                {
                    x.SetServiceName("Topshelf.Quartz.Abp.SampleService");
                    x.SetDescription("Topshelf.Quartz.Abp Sample Service");
                    x.UseQuartzAbp(bootstrapper);
                    x.ScheduleQuartzJobAsService(q =>
                        q.WithJob(() => JobBuilder.Create<OUSyncServiceJob>().Build())
                            .AddTrigger(() => TriggerBuilder.Create()
                                .WithSimpleSchedule(builder => builder
                                    .WithIntervalInSeconds(30)
                                    .RepeatForever())
                                .Build())
                    );
                });
            }
        }
    }
}