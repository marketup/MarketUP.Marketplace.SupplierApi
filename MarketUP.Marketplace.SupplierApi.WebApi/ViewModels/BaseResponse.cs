using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class BaseResponse
    {
        public List<MessageItem> Messages { get; set; }

        public void AddMessage(int code, string message, string exception = null)
        {
            AddMessage(code.ToString(), message, exception);
        }

        public void AddMessage(string code, string message, string exception = null)
        {
            if (Messages == null)
                Messages = new List<MessageItem>();

            Messages.Add(new MessageItem(code, message, exception));
        }

        public BaseResponse()
        {
        }
    }
}
