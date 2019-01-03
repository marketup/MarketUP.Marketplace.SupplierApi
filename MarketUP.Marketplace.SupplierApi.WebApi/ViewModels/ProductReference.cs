using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class ProductReference
    {
        [JsonProperty("productID")]
        public string ProductID { get; set; }

        public ProductReference()
        {

        }

        public ProductReference(string productID)
        {
            this.ProductID = productID;
        }
    }
}
