using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Common
{
    public enum PaymentConditionTypesEnum
    {
        None = 0,
        SupplierBilling = 1,
        CreditCardElo = 2,
        CreditCardAmex = 3,
        CreditCardMastercard = 4,
        CreditCardVisa = 5,
        CreditCardDiners = 6,
        CreditCardHipercard = 7,
        BankSlip = 8,
        Paypal = 9,
        CreditCard = 10,
        GiftCard = 11
    }
}
