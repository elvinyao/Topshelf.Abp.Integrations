using System;
using Abp.Dependency;
using Quartz;

namespace TCC.OUSyncService
{
    public class OUSyncServiceJob : IJob, ITransientDependency
    {
        private readonly OUSyncServiceDependency _ouSyncServiceDependency;

        public OUSyncServiceJob(OUSyncServiceDependency ouSyncServiceDependency)
        {
            _ouSyncServiceDependency = ouSyncServiceDependency;
        }

        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("Job executed");
            _ouSyncServiceDependency.DoWork();
        }
    }
}