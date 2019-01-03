using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class OrderStatusHistory
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("orderStatus")]
        public string OrderStatus { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        public OrderStatusHistory()
        {

        }

        public OrderStatusHistory(DateTime date, string orderStatus, string notes)
        {
            this.Date = date;
            this.OrderStatus = orderStatus;
            this.Notes = notes;
        }
    }
}
