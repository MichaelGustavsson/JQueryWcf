using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Demo
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebInvoke(Method="GET")]
        IQueryable<Customer> GetCustomers();
    }
}
