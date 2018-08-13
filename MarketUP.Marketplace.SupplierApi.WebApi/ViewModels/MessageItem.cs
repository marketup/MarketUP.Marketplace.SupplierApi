using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class MessageItem
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public MessageItem(string code, string message)
        {
            this.Code = code;
            this.Message = message;
        }
    }
}
