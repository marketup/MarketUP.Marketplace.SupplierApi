using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class ShoppingPaymentCondition
    {
        [JsonProperty("paymentConditionID")]
        public string PaymentConditionID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("paymentConditionType")]
        public string PaymentConditionType { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }

        [JsonProperty("installments")]
        public List<PaymentInstallment> Installments { get; set; }

        public int? DaysForPayment { get; set; }

        public ShoppingPaymentCondition()
        {
            
        }

        public ShoppingPaymentCondition(string paymentConditionID, string name, string paymentConditionType, decimal value, List<PaymentInstallment> installments, int? daysForPayment)
        {
            this.PaymentConditionID = paymentConditionID;
            this.Name = name;
            this.PaymentConditionType = paymentConditionType;
            this.Value = value;
            this.Installments = installments;
            this.DaysForPayment = daysForPayment;
        }
    }
}
