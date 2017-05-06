using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace CRUDInRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceVehicle" in both code and config file together.
    [ServiceContract]
    public interface IServiceVehicle
    {
        [OperationContract]
        [WebInvoke(Method="GET", UriTemplate ="getall",
            ResponseFormat =WebMessageFormat.Json)]
        List<Vehicle> getall();


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "get/{id}",
            ResponseFormat = WebMessageFormat.Json)]
        Vehicle get (string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create",
          ResponseFormat = WebMessageFormat.Json, RequestFormat =WebMessageFormat.Json)]
        bool create(Vehicle vehicle);

        [OperationContract]
        [WebInvoke(Method = "PUR", UriTemplate = "edit",
  ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool edit(Vehicle vehicle);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete",
  ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool delete(Vehicle vehicle);
    }
}
