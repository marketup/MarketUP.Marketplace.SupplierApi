using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class ShoppingProductResponse
    {
        [JsonProperty("productID")]
        public string ProductID { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("isBox")]
        public bool IsBox { get; set; }

        [JsonProperty("seller")]
        public string Seller { get; set; }

        [JsonProperty("stockQuantity")]
        public int? StockQuantity { get; set; }

        [JsonProperty("unitValue")]
        public decimal UnitValue { get; set; }

        public ShoppingProductResponse()
        {

        }

        public ShoppingProductResponse(string productID, int quantity, bool isBox, string seller, int? stockQuantity, decimal unitValue)
        {
            this.ProductID = productID;
            this.Quantity = quantity;
            this.IsBox = isBox;
            this.Seller = seller;
            this.StockQuantity = stockQuantity;
            this.UnitValue = unitValue;
        }
    }
}
