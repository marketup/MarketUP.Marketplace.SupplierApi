using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class PaymentInformation
    {
        [JsonProperty("paymentConditionID")]
        public string PaymentConditionID { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }

        [JsonProperty("installmentsQuantity")]
        public int InstallmentsQuantity { get; set; }

        [JsonProperty("cardNumber")]
        public string CardNumber { get; set; }

        [JsonProperty("holderName")]
        public string HolderName { get; set; }

        [JsonProperty("dueYear")]
        public int DueYear { get; set; }

        [JsonProperty("dueMonth")]
        public int DueMonth { get; set; }

        [JsonProperty("validationCode")]
        public string ValidationCode { get; set; }

        public PaymentInformation()
        {

        }

        public PaymentInformation(string paymentConditionID, decimal value, int installmentsQuantity, string cardNumber, string holderName, int dueYear, int dueMonth, string validationCode)
        {
            this.PaymentConditionID = paymentConditionID;
            this.Value = value;
            this.InstallmentsQuantity = installmentsQuantity;
            this.CardNumber = cardNumber;
            this.HolderName = holderName;
            this.DueYear = dueYear;
            this.DueMonth = dueMonth;
            this.ValidationCode = validationCode;
        }
    }
}
