using System;
using Abp.Application.Services;
using Castle.Core.Logging;

namespace TCC.OUSyncService.AppService
{
    public class OUSyncAppService : ApplicationService, IOUSyncAppService
    {
        public ILogger Logger { get; set; }

        public OUSyncAppService(ILogger logger)
        {
            Logger = NullLogger.Instance;
        }

        public void DoOUSync()
        {
            Logger.Debug("DoOUSync work start");
            Console.WriteLine("DoOUSync work");
            Logger.Debug("DoOUSync work end");
        }

        public void DoEmployeesSync()
        {
            Logger.Debug("DoEmployeesSync work start");
            Console.WriteLine("DoEmployeesSync work");
            Logger.Debug("DoEmployeesSync work start");
        }
    }
}