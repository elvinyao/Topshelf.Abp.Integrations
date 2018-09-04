using Abp.Application.Services;

namespace TCC.OUSyncService.AppService
{
    public interface IOUSyncAppService : IApplicationService
    {
        void DoOUSync();
        void DoEmployeesSync();
    }
}