using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class BaseResponseErp
    {
        public bool success { get; set; }

        public string message { get; set; }

        public string errorMessage { get; set; }
    }
}
