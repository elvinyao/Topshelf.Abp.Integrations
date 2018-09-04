using System;
using Abp.Dependency;
using Castle.Core.Logging;
using Quartz;
using TCC.OUSyncService.AppService;

namespace TCC.OUSyncService
{
    public class OUSyncServiceJob : IJob, ITransientDependency
    {
        private readonly IOUSyncAppService _ouSyncAppService;
        public ILogger Logger { get; set; }

        public OUSyncServiceJob(IOUSyncAppService ouSyncAppService)
        {
            _ouSyncAppService = ouSyncAppService;
            Logger = NullLogger.Instance;
        }

        public void Execute(IJobExecutionContext context)
        {
            _ouSyncAppService.DoOUSync();
            _ouSyncAppService.DoEmployeesSync();
        }
    }
}