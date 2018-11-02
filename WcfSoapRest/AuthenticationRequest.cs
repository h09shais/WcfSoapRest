using System.Runtime.Serialization;

namespace WcfSoapRest
{
    [DataContract]
    public class AuthenticationRequest
    {
        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}