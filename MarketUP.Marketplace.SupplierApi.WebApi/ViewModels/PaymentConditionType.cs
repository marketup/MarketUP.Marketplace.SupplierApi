using Newtonsoft.Json;
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
        public const string CREDIT_CARD = "credit-card";
        public const string BANK_SLIP = "bank-slip";
        
        //-------

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("daysForPayment")]
        public int? DaysForPayment { get; set; }

        public MarketUP.Marketplace.Common.PaymentConditionTypesEnum PaymentConditionTypeEnum { get; set; }

        public MarketUP.Marketplace.Common.PaymentConditionGroupsEnum PaymentConditionGroupEnum { get; set; }

        //-------

        public PaymentConditionType()
        {
            this.PaymentConditionTypeEnum = Common.PaymentConditionTypesEnum.None;
        }

        public PaymentConditionType(string code, string name, MarketUP.Marketplace.Common.PaymentConditionTypesEnum paymentConditionTypeEnum, 
            MarketUP.Marketplace.Common.PaymentConditionGroupsEnum paymentConditionGroupEnum, int? daysForPayment)
        {
            this.Code = code;
            this.Name = name;
            this.PaymentConditionTypeEnum = paymentConditionTypeEnum;
            this.PaymentConditionGroupEnum = paymentConditionGroupEnum;
            this.DaysForPayment = daysForPayment;
        }

        public static List<PaymentConditionType> List()
        {
            var list = new List<PaymentConditionType>();
            list.Add(new PaymentConditionType(SUPPLIER_BILLING,         "Faturado pelo fornecedor",         Common.PaymentConditionTypesEnum.SupplierBilling,           Common.PaymentConditionGroupsEnum.SupplierBilling,  null));
            list.Add(new PaymentConditionType(CREDIT_CARD_ELO,          "Cartão de crédito Elo",            Common.PaymentConditionTypesEnum.CreditCardElo,             Common.PaymentConditionGroupsEnum.CreditCard,       null));
            list.Add(new PaymentConditionType(CREDIT_CARD_AMEX,         "Cartão de crédito Amex",           Common.PaymentConditionTypesEnum.CreditCardAmex,            Common.PaymentConditionGroupsEnum.CreditCard,       null));
            list.Add(new PaymentConditionType(CREDIT_CARD_MASTERCARD,   "Cartão de crédito Mastercard",     Common.PaymentConditionTypesEnum.CreditCardMastercard,      Common.PaymentConditionGroupsEnum.CreditCard,       null));
            list.Add(new PaymentConditionType(CREDIT_CARD_VISA,         "Cartão de crédito Visa",           Common.PaymentConditionTypesEnum.CreditCardVisa,            Common.PaymentConditionGroupsEnum.CreditCard,       null));
            list.Add(new PaymentConditionType(CREDIT_CARD_DINERS,       "Cartão de crédito Dinners",        Common.PaymentConditionTypesEnum.CreditCardDiners,          Common.PaymentConditionGroupsEnum.CreditCard,       null));
            list.Add(new PaymentConditionType(CREDIT_CARD_HIPERCARD,    "Cartão de crédito Hipercard",      Common.PaymentConditionTypesEnum.CreditCardHipercard,       Common.PaymentConditionGroupsEnum.CreditCard,       null));
            list.Add(new PaymentConditionType(CREDIT_CARD,              "Cartão de crédito",                Common.PaymentConditionTypesEnum.CreditCard,                Common.PaymentConditionGroupsEnum.CreditCard,       null));
            list.Add(new PaymentConditionType(BANK_SLIP,                "Boleto bancário",                  Common.PaymentConditionTypesEnum.BankSlip,                  Common.PaymentConditionGroupsEnum.BankSlip,         null));
            list.Add(new PaymentConditionType(BANK_SLIP,                "Boleto bancário (7 dias)",         Common.PaymentConditionTypesEnum.BankSlip,                  Common.PaymentConditionGroupsEnum.BankSlip,         7));
            list.Add(new PaymentConditionType(BANK_SLIP,                "Boleto bancário (14 dias)",        Common.PaymentConditionTypesEnum.BankSlip,                  Common.PaymentConditionGroupsEnum.BankSlip,         14));
            list.Add(new PaymentConditionType(BANK_SLIP,                "Boleto bancário (30 dias)",        Common.PaymentConditionTypesEnum.BankSlip,                  Common.PaymentConditionGroupsEnum.BankSlip,         30));
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
