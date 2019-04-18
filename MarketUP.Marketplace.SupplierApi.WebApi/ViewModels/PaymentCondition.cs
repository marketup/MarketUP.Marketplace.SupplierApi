using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class PaymentCondition
    {
        [JsonProperty("paymentConditionID")]
        public string PaymentConditionID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("paymentConditionType")]
        public string PaymentConditionType { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("daysForPayment")]
        public int? DaysForPayment { get; set; }

        public PaymentCondition()
        {

        }

        public PaymentCondition(string paymentCondition, string name, string paymentConditionType, int order, bool isDefault, int? daysForPayment)
        {
            this.PaymentConditionID = paymentCondition;
            this.Name = name;
            this.PaymentConditionType = paymentConditionType;
            this.Order = order;
            this.IsDefault = isDefault;
            this.DaysForPayment = daysForPayment;
        }
    }
}
