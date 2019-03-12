using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class OrderSendResponse
    {
        [JsonProperty("orderID")]
        public string OrderID { get; set; }

        [JsonProperty("urlOrder")]
        public string UrlOrder { get; set; }

        [JsonProperty("registerKey")]
        public string RegisterKey { get; set; }

        [JsonProperty("urlCheckStatus")]
        public string UrlCheckStatus { get; set; }

        [JsonProperty("bankSlipUrl")]
        public string BankSlipUrl { get; set; }

        public OrderSendResponse()
        {

        }

        public OrderSendResponse(string orderID, string urlOrder, string registerKey, string urlCheckStatus, string bankSlipUrl)
        {
            this.OrderID = orderID;
            this.UrlOrder = urlOrder;
            this.RegisterKey = registerKey;
            this.UrlCheckStatus = urlCheckStatus;
            this.BankSlipUrl = bankSlipUrl;
        }
    }
}
