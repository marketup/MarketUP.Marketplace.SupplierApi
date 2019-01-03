using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class ShippingInformation
    {
        [JsonProperty("shippingTypeID")]
        public string ShippingTypeID { get; set; }

        public ShippingInformation()
        {

        }

        public ShippingInformation(string shippingTypeID)
        {
            this.ShippingTypeID = shippingTypeID;
        }
    }
}
