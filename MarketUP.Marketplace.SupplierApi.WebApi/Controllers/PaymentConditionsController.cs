using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MarketUP.Marketplace.SupplierApi.WebApi.Controllers
{
    [RoutePrefix("payment-conditions")]
    public class PaymentConditionsController : BaseApiController
    {
        [Route(""), HttpGet]
        public CustomActionResult<Integration.ModelsSupplierApi.PaymentConditionListResponse> List()
        {
            var response = new Integration.ModelsSupplierApi.PaymentConditionListResponse();

            try
            {
                response.PaymentConditions = new List<Integration.ModelsSupplierApi.PaymentCondition>();

                response.PaymentConditions.Add(new Integration.ModelsSupplierApi.PaymentCondition() { PaymentConditionID = "p01", PaymentConditionType = Integration.ModelsSupplierApi.PaymentConditionType.SUPPLIER_BILLING, Name = "Faturamento" });
                response.PaymentConditions.Add(new Integration.ModelsSupplierApi.PaymentCondition() { PaymentConditionID = "p02", PaymentConditionType = Integration.ModelsSupplierApi.PaymentConditionType.CREDIT_CARD_ELO, Name = "Cartão de crédito Elo" });
                response.PaymentConditions.Add(new Integration.ModelsSupplierApi.PaymentCondition() { PaymentConditionID = "p03", PaymentConditionType = Integration.ModelsSupplierApi.PaymentConditionType.CREDIT_CARD_AMEX, Name = "Cartão de crédito Amex" });
                response.PaymentConditions.Add(new Integration.ModelsSupplierApi.PaymentCondition() { PaymentConditionID = "p04", PaymentConditionType = Integration.ModelsSupplierApi.PaymentConditionType.CREDIT_CARD_MASTERCARD, Name = "Cartão de crédito Mastercard" });
                response.PaymentConditions.Add(new Integration.ModelsSupplierApi.PaymentCondition() { PaymentConditionID = "p05", PaymentConditionType = Integration.ModelsSupplierApi.PaymentConditionType.CREDIT_CARD_VISA, Name = "Cartão de crédito Visa" });
                response.PaymentConditions.Add(new Integration.ModelsSupplierApi.PaymentCondition() { PaymentConditionID = "p06", PaymentConditionType = Integration.ModelsSupplierApi.PaymentConditionType.CREDIT_CARD_DINERS, Name = "Cartão de crédito Diners" });
                response.PaymentConditions.Add(new Integration.ModelsSupplierApi.PaymentCondition() { PaymentConditionID = "p07", PaymentConditionType = Integration.ModelsSupplierApi.PaymentConditionType.CREDIT_CARD_HIPERCARD, Name = "Cartão de crédito Hipercard" });
                response.PaymentConditions.Add(new Integration.ModelsSupplierApi.PaymentCondition() { PaymentConditionID = "p08", PaymentConditionType = Integration.ModelsSupplierApi.PaymentConditionType.BANK_SLIP, Name = "Boleto Bancário" });

                return this.GetResultOK(response);
            }
            catch (System.Exception ex)
            {
                string errorMessage = "Erro ao listar formas de pagamento";
                response.AddMessage("500", errorMessage);
                UtilsApi.WriteError(errorMessage, ex);
                return this.GetResultInternalServerError(response);
            }
        }
    }
}