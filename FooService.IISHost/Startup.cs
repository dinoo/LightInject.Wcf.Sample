using FooService.IISHost;

[assembly: System.Web.PreApplicationStartMethod(typeof(Startup), "Initialize")]
namespace FooService.IISHost
{
    using Library;
    using LightInject;
    using LightInject.Wcf;

    public class Startup
    {
        public static void Initialize()
        {
            var container = new ServiceContainer();
            container.RegisterFrom<CompositionRoot>();
            LightInjectServiceHostFactory.Container = container;
        }
    }
}
