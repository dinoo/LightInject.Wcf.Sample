using FooService.Contracts;
using System.ServiceModel;
using System;

namespace FooService.Library
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class FooService : IFooService
    {
        public string ServiceAction()
        {
            return Guid.NewGuid().ToString();
        }
    }
}