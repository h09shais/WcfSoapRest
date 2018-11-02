using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfSoapRest
{
    [ServiceContract]
    public interface ISimpleService
    {
        [OperationContract]
        [WebInvoke(
            Method = "PUT",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "AuthReq")]
        AuthorizationResponse Authenticate(AuthenticationRequest request);
    }
}
