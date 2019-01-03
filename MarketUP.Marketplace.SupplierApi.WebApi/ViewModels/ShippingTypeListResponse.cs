using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class ShippingTypeListResponse : BaseResponse
    {
        [JsonProperty("shippingTypes")]
        public List<ShippingType> ShippingTypes { get; set; }
    }
}
