using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class PaymentConditionListResponse : BaseResponse
    {
        [JsonProperty("paymentConditions")]
        public List<PaymentCondition> PaymentConditions { get; set; }
    }
}
