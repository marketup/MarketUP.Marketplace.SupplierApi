using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class ClientPaymentCondition
    {
        [JsonProperty("paymentConditionID")]
        public string PaymentConditionID { get; set; }

        [JsonProperty("minimumOrderValue")]
        public decimal? MinimumOrderValue { get; set; }

        [JsonProperty("maximumOrderValue")]
        public decimal? MaximumOrderValue { get; set; }

        public ClientPaymentCondition()
        {

        }

        public ClientPaymentCondition(string paymentConditionID, decimal? minimumOrderValue, decimal? maximumOrderValue)
        {
            this.PaymentConditionID = paymentConditionID;
            this.MinimumOrderValue = minimumOrderValue;
            this.MaximumOrderValue = maximumOrderValue;
        }
    }
}
