using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class ClientRegisterResponse : BaseResponse
    {
        [JsonProperty("clientID")]
        public string ClientID { get; set; }

        [JsonProperty("urlClient")]
        public string UrlClient { get; set; }

        [JsonProperty("registerKey")]
        public string RegisterKey { get; set; }

        [JsonProperty("urlCheckStatus")]
        public string UrlCheckStatus { get; set; }

        public ClientRegisterResponse()
        {

        }

        public ClientRegisterResponse(string clientID, string urlClient, string registerKey, string urlCheckStatus)
        {
            this.ClientID = clientID;
            this.UrlClient = urlClient;
            this.RegisterKey = registerKey;
            this.UrlCheckStatus = urlCheckStatus;
        }
    }
}
