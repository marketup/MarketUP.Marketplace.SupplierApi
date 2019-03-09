using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class SupplierDeliveryRestriction
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        public SupplierDeliveryRestriction()
        {

        }

        public SupplierDeliveryRestriction(string state, string city)
        {
            this.State = state;
            this.City = city;
        }
    }
}
