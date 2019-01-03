using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class PaymentInstallment
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }

        [JsonProperty("total")]
        public decimal Total { get; set; }

        [JsonProperty("hasInterestRate")]
        public bool HasInterestRate { get; set; }

        [JsonProperty("interestRate")]
        public decimal? InterestRate { get; set; }

        public PaymentInstallment()
        {

        }

        public PaymentInstallment(int quantity, decimal value, decimal total, bool hasInterestRate, decimal? interestRate)
        {
            this.Quantity = quantity;
            this.Value = value;
            this.Total = total;
            this.HasInterestRate = hasInterestRate;
            this.InterestRate = interestRate;
        }
    }
}
