using System.ServiceModel;

namespace FooService.Contracts
{
    [ServiceContract]
    public interface IFooService
    {
        [OperationContract]
        string ServiceAction();
    }
}
