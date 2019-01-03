using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class ShoppingShippingType
    {
        [JsonProperty("shippingTypeID")]
        public string ShippingTypeID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }

        [JsonProperty("shippingEstimateDays")]
        public int? ShippingEstimateDays { get; set; }

        [JsonProperty("shippingEstimateIsBusinessDays")]
        public bool ShippingEstimateIsBusinessDays { get; set; }

        public ShoppingShippingType()
        {

        }

        public ShoppingShippingType(string shippingTypeID, string name, decimal value, int? shippingEstimateDays, bool shippingEstimateIsBusinessDays)
        {
            this.ShippingTypeID = shippingTypeID;
            this.Name = name;
            this.Value = value;
            this.ShippingEstimateDays = shippingEstimateDays;
            this.ShippingEstimateIsBusinessDays = shippingEstimateIsBusinessDays;
        }
    }
}
