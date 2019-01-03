using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class ShoppingProductRequest
    {
        [JsonProperty("productID")]
        public string ProductID { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("isBox")]
        public bool IsBox { get; set; }

        [JsonProperty("seller")]
        public string Seller { get; set; }

        public ShoppingProductRequest()
        {

        }

        public ShoppingProductRequest(string productID, int quantity, bool isBox, string seller)
        {
            this.ProductID = productID;
            this.Quantity = quantity;
            this.IsBox = isBox;
            this.Seller = seller;
        }
    }
}
