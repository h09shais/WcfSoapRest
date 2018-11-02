using System;
using System.ServiceModel.Web;

namespace WcfSoapRest
{
    public class SimpleService : ISimpleService
    {
        public AuthorizationResponse Authenticate(AuthenticationRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (WebOperationContext.Current != null)
            {
                WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;
            }

            AuthorizationResponse response;

            if (!string.IsNullOrEmpty(request.Username) && !string.IsNullOrEmpty(request.Password))
            {
                response = new AuthorizationResponse
                {
                    Valid = true,
                    ValidToDate = DateTime.Now.AddDays(1), // For fun !!
                    Message = "OK",
                    ReturnUrl = "http://test.test/"
                };
            }
            else
            {
                response = new AuthorizationResponse
                {
                    Valid = false,
                    ValidToDate = null,
                    Message = "Unable to authenticate",
                    ReturnUrl = string.Empty
                };
            }

            return response;
        }
    }
}
