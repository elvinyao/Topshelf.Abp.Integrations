using System;
using Abp.Dependency;
using Castle.Core.Logging;
using Quartz;

namespace TCC.OUSyncService
{
    public class OUSyncServiceJob : IJob, ITransientDependency
    {
        private readonly OUSyncServiceDependency _ouSyncServiceDependency;
        public ILogger Logger { get; set; }

        public OUSyncServiceJob(OUSyncServiceDependency ouSyncServiceDependency)
        {
            _ouSyncServiceDependency = ouSyncServiceDependency;
            Logger = NullLogger.Instance;
        }

        public void Execute(IJobExecutionContext context)
        {
            Logger.Debug("Job executed");
            Console.WriteLine("Job executed");
            _ouSyncServiceDependency.DoWork();
            Logger.Debug("Job done");
        }
    }
}