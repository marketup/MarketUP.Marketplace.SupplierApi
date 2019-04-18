using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Common
{
    public enum PaymentStatusEnum
    {
        none,
        refused,
        authorized,
        waitingPayment,
        paid,
        pendingRefund,
        refunded,
        processing,
        pendingReview
    }
}
