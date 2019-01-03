using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class ProductRestriction
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }

        [JsonProperty("boxValue")]
        public decimal BoxValue { get; set; }

        public ProductRestriction()
        {

        }

        public ProductRestriction(string state, decimal value, decimal boxValue)
        {
            this.State = state;
            this.Value = value;
            this.BoxValue = boxValue;
        }
    }
}
