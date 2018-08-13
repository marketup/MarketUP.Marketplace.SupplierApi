using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class PaymentConditionType
    {
        public const string SUPPLIER_BILLING = "supplier-billing";
        public const string CREDIT_CARD_ELO = "credit-card-elo";
        public const string CREDIT_CARD_AMEX = "credit-card-amex";
        public const string CREDIT_CARD_MASTERCARD = "credit-card-mastercard";
        public const string CREDIT_CARD_VISA = "credit-card-visa";
        public const string CREDIT_CARD_DINERS = "credit-card-dinners";
        public const string CREDIT_CARD_HIPERCARD = "credit-card-hipercard";
        public const string BANK_SLIP = "bank-slip";

        //-------

        public string Code { get; set; }

        public string Name { get; set; }
        
        public MarketUP.Marketplace.Common.PaymentConditionTypesEnum PaymentConditionTypeEnum { get; set; }

        public MarketUP.Marketplace.Common.PaymentConditionGroupsEnum PaymentConditionGroupEnum { get; set; }

        //-------

        public PaymentConditionType()
        {
            this.PaymentConditionTypeEnum = Common.PaymentConditionTypesEnum.None;
        }

        public PaymentConditionType(string code, string name, MarketUP.Marketplace.Common.PaymentConditionTypesEnum paymentConditionTypeEnum, MarketUP.Marketplace.Common.PaymentConditionGroupsEnum paymentConditionGroupEnum)
        {
            this.Code = code;
            this.Name = name;
            this.PaymentConditionTypeEnum = paymentConditionTypeEnum;
            this.PaymentConditionGroupEnum = paymentConditionGroupEnum;
        }

        public static List<PaymentConditionType> List()
        {
            var list = new List<PaymentConditionType>();
            list.Add(new PaymentConditionType(SUPPLIER_BILLING,         "Faturado pelo fornecedor",         Common.PaymentConditionTypesEnum.SupplierBilling,           Common.PaymentConditionGroupsEnum.SupplierBilling));
            list.Add(new PaymentConditionType(CREDIT_CARD_ELO,          "Cartão de crédito Elo",            Common.PaymentConditionTypesEnum.CreditCardElo,             Common.PaymentConditionGroupsEnum.CreditCard));
            list.Add(new PaymentConditionType(CREDIT_CARD_AMEX,         "Cartão de crédito Amex",           Common.PaymentConditionTypesEnum.CreditCardAmex,            Common.PaymentConditionGroupsEnum.CreditCard));
            list.Add(new PaymentConditionType(CREDIT_CARD_MASTERCARD,   "Cartão de crédito Mastercard",     Common.PaymentConditionTypesEnum.CreditCardMastercard,      Common.PaymentConditionGroupsEnum.CreditCard));
            list.Add(new PaymentConditionType(CREDIT_CARD_VISA,         "Cartão de crédito Visa",           Common.PaymentConditionTypesEnum.CreditCardVisa,            Common.PaymentConditionGroupsEnum.CreditCard));
            list.Add(new PaymentConditionType(CREDIT_CARD_DINERS,       "Cartão de crédito Dinners",        Common.PaymentConditionTypesEnum.CreditCardDiners,          Common.PaymentConditionGroupsEnum.CreditCard));
            list.Add(new PaymentConditionType(CREDIT_CARD_HIPERCARD,    "Cartão de crédito Hipercard",      Common.PaymentConditionTypesEnum.CreditCardHipercard,       Common.PaymentConditionGroupsEnum.CreditCard));
            list.Add(new PaymentConditionType(BANK_SLIP,                "Boleto bancário",                  Common.PaymentConditionTypesEnum.BankSlip,                  Common.PaymentConditionGroupsEnum.BankSlip));
            return list;
        }

        public static PaymentConditionType GetByCode(string code)
        {
            return List().Where(a => a.Code.Equals(code, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
        }

        public static PaymentConditionType GetByEnum(MarketUP.Marketplace.Common.PaymentConditionTypesEnum paymentConditionTypesEnum)
        {
            return List().Where(a => a.PaymentConditionTypeEnum == paymentConditionTypesEnum).FirstOrDefault();
        }
    }
}
