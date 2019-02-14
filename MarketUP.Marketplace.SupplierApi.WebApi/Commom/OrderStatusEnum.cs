using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Common
{
    public enum OrderStatusEnum
    {
        None = 0,

        New = 1,

        PaymentPending = 15,

        PaymentApproved = 20,

        Invoiced = 30,

        WaitingForSellerDecision = 35,

        Sent = 37,

        Delivering = 39,

        Delivered = 40,

        DeliveryProblem = 41,

        Finished = 50,

        Canceled = 60,

        Unavailable = 100
    }
}
