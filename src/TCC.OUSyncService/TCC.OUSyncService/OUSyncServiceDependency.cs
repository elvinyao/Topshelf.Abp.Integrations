using System;
using Abp.Dependency;

namespace TCC.OUSyncService
{
    public class OUSyncServiceDependency : ITransientDependency
    {
        public void DoWork()
        {
            Console.WriteLine("Sample work");
        }
    }
}