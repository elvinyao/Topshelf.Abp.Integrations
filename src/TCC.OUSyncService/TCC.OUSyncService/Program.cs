using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp;
using Abp.Castle.Logging.Log4Net;
using Castle.Facilities.Logging;
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
            using (var bootstrapper = AbpBootstrapper.Create<OUSyncServiceAbpModule>())
            {
                bootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                    f => f.UseAbpLog4Net().WithConfig($"{GetAppPath()}log4net.config")
                );
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

        private static string GetAppPath()
        {
            string appPath = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            if (!appPath.EndsWith(Path.DirectorySeparatorChar.ToString()))
                appPath += Path.DirectorySeparatorChar;
            return appPath;
        }
    }
}