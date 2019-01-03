using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class OrderProduct
    {
        [JsonProperty("productID")]
        public string ProductID { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("isBox")]
        public bool IsBox { get; set; }

        public OrderProduct()
        {

        }

        public OrderProduct(string productID, int quantity, bool isBox)
        {
            this.ProductID = productID;
            this.Quantity = quantity;
            this.IsBox = isBox;
        }
    }
}
