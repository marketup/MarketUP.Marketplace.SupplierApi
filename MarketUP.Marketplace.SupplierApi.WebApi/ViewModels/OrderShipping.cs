using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class OrderShipping
    {
        [JsonProperty("shipmentDate")]
        public DateTime? ShipmentDate { get; set; }

        [JsonProperty("deliveryDate")]
        public DateTime? DeliveryDate { get; set; }

        [JsonProperty("shippingTypeName")]
        public string ShippingTypeName { get; set; }

        [JsonProperty("trackingNumber")]
        public string TrackingNumber { get; set; }

        [JsonProperty("trackingUrl")]
        public string TrackingUrl { get; set; }

        public OrderShipping()
        {

        }

        public OrderShipping(DateTime? shipmentDate, DateTime? deliveryDate, string shippingTypeName, string trackingNumber, string trackingUrl)
        {
            this.ShipmentDate = shipmentDate;
            this.DeliveryDate = deliveryDate;
            this.ShippingTypeName = shippingTypeName;
            this.TrackingNumber = trackingNumber;
            this.TrackingUrl = trackingUrl;
        }
    }
}
