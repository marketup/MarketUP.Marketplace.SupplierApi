using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class PaymentCondition
    {
        public string PaymentConditionID { get; set; }

        public string Name { get; set; }

        public string PaymentConditionType { get; set; }
    }
}
