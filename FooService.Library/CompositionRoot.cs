using FooService.Contracts;
using LightInject;

namespace FooService.Library
{
    public class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IBarRepository, BarRepository>();
            serviceRegistry.Register<IFooService, FooService>();
            serviceRegistry.Register<IBarService, BarService>();
        }
    }
}
