using System.ServiceModel;

namespace FooService.Contracts
{
    [ServiceContract]
    public interface IBarService
    {
        [OperationContract]
        string ServiceAction();
    }
}
