using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class ShoppingCartRequest
    {
        [JsonProperty("clientID")]
        public string ClientID { get; set; }
        
        [JsonProperty("paymentConditionID")]
        public string PaymentConditionID { get; set; }

        [JsonProperty("products")]
        public List<ShoppingProductRequest> Products { get; set; }

        [JsonProperty("deliveryAddress")]
        public DeliveryAddress DeliveryAddress { get; set; }

        public ShoppingCartRequest()
        {

        }

        public ShoppingCartRequest(string clientID, string paymentConditionID, List<ShoppingProductRequest> products, DeliveryAddress deliveryAddress)
        {
            this.ClientID = clientID;
            this.PaymentConditionID = paymentConditionID;
            this.Products = products;
            this.DeliveryAddress = deliveryAddress;
        }
    }
}
