using FooService.Contracts;
using System.ServiceModel;

namespace FooService.Library
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class BarService : IBarService
    {
        private IBarRepository repository;

        public BarService(IBarRepository repository)
        {
            this.repository = repository;
        }

        public string ServiceAction()
        {
            return repository.GetItem();
        }
    }
}
