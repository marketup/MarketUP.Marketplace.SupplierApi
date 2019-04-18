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
        
        [JsonProperty("documentNumber")]
        public string DocumentNumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }


        [JsonProperty("billingAddressStreet")]
        public string BillingAddressStreet { get; set; }

        [JsonProperty("billingAddressNumber")]
        public string BillingAddressNumber { get; set; }

        [JsonProperty("billingAddressQuarter")]
        public string BillingAddressQuarter { get; set; }

        [JsonProperty("billingAddressComplement")]
        public string BillingAddressComplement { get; set; }

        [JsonProperty("billingAddressCity")]
        public string BillingAddressCity { get; set; }

        [JsonProperty("billingAddressState")]
        public string BillingAddressState { get; set; }

        [JsonProperty("billingAddressCountry")]
        public string BillingAddressCountry { get; set; }

        [JsonProperty("billingAddressZipCode")]
        public string BillingAddressZipCode { get; set; }


        public PaymentInformation()
        {

        }

        public PaymentInformation(string paymentConditionID, decimal value, int installmentsQuantity, string cardNumber, string holderName, int dueYear, int dueMonth, string validationCode, string documentNumber, string billingAddressStreet, string billingAddressNumber, string billingAddressQuarter, string billingAddressComplement, string billingAddressState, string billingAddressCountry, string billingAddressCity, string billingAddressZipCode, string status)
        {
            this.PaymentConditionID = paymentConditionID;
            this.Value = value;
            this.InstallmentsQuantity = installmentsQuantity;
            this.CardNumber = cardNumber;
            this.HolderName = holderName;
            this.DueYear = dueYear;
            this.DueMonth = dueMonth;
            this.ValidationCode = validationCode;
            this.DocumentNumber = documentNumber;
            this.BillingAddressStreet = billingAddressStreet;
            this.BillingAddressNumber = billingAddressNumber;
            this.BillingAddressQuarter = billingAddressQuarter;
            this.BillingAddressState = billingAddressState;
            this.BillingAddressCountry = billingAddressCountry;
            this.BillingAddressCity = billingAddressCity;
            this.BillingAddressZipCode = billingAddressZipCode;
            this.BillingAddressComplement = billingAddressComplement;
            this.Status = status;
        }
    }
}
