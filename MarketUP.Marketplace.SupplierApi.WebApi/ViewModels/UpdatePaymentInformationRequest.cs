using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class UpdatePaymentInformationRequest
    {
        [JsonProperty("orderID")]
        public string OrderID { get; set; }

        [JsonProperty("paymentInformation")]
        public PaymentInformation PaymentInformation { get; set; }

        public UpdatePaymentInformationRequest()
        {

        }

        public UpdatePaymentInformationRequest(string orderID, PaymentInformation paymentInformation)
        {
            this.OrderID = orderID;
            this.PaymentInformation = paymentInformation;
        }
    }
}
