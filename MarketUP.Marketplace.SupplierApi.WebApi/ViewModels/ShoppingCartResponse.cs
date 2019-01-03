using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class ShoppingCartResponse : BaseResponse
    {
        [JsonProperty("products")]
        public List<ShoppingProductResponse> Products { get; set; }

        [JsonProperty("paymentConditions")]
        public List<ShoppingPaymentCondition> PaymentConditions { get; set; }

        [JsonProperty("shippingTypes")]
        public List<ShoppingShippingType> ShippingTypes { get; set; }

        public ShoppingCartResponse()
        {

        }

        public ShoppingCartResponse(List<ShoppingProductResponse> products, List<ShoppingPaymentCondition> paymentConditions, List<ShoppingShippingType> shippingTypes)
        {
            this.Products = products;
            this.PaymentConditions = paymentConditions;
            this.ShippingTypes = shippingTypes;
        }
    }
}
