using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MarketUP.Marketplace.SupplierApi.WebApi.Controllers
{
    [RoutePrefix("supplier")]
    public class SupplierController : BaseApiController
    {
        [Route(""), HttpGet]
        public CustomActionResult<Integration.ModelsSupplierApi.Supplier> Get()
        {
            var response = new Integration.ModelsSupplierApi.Supplier();

            try
            {
                //TODO: Substituir pelos dados reais

                response.Name = "Distribuidora Chaves";
                response.CompanyOfficialName = "Chaves distribuidora de bebidas";
                response.Cnpj = "11.111.111/0001-11";
                response.Ie = "123456";
                response.IntegrationNotificationEmail = "integracao-marketup@chavesdistribuidor.com.br";
                response.Phone = "(11) 6666-6666";
                response.Email = "sac@chavesdistribuidor.com.br";
                response.Address = new Integration.ModelsSupplierApi.Address("Avenida Paulista", "925", "3º andar", "Cerqueira César", "03111-000", "São Paulo", "SP", "Brasil");
                response.AboutText = "<p>Distribuidora de bebidas a mais de 100 anos no mercado</p><p>Lorem ipsum dolor sit amet.</p>";
                response.PolicyText = "<p>Vivamus sit amet dignissim lectus, sit amet interdum orci. Vestibulum posuere vestibulum ipsum, eu scelerisque nisi volutpat ac.</p>";

                //Formas de pagamento
                response.PaymentConditions = new List<Integration.ModelsSupplierApi.PaymentCondition>();
                response.PaymentConditions.Add(new Integration.ModelsSupplierApi.PaymentCondition() { PaymentConditionID = "p01", PaymentConditionType = Integration.ModelsSupplierApi.PaymentConditionType.SUPPLIER_BILLING, Name = "Faturamento" });
                response.PaymentConditions.Add(new Integration.ModelsSupplierApi.PaymentCondition() { PaymentConditionID = "p02", PaymentConditionType = Integration.ModelsSupplierApi.PaymentConditionType.CREDIT_CARD_ELO, Name = "Cartão de crédito Elo" });
                response.PaymentConditions.Add(new Integration.ModelsSupplierApi.PaymentCondition() { PaymentConditionID = "p03", PaymentConditionType = Integration.ModelsSupplierApi.PaymentConditionType.CREDIT_CARD_AMEX, Name = "Cartão de crédito Amex" });
                response.PaymentConditions.Add(new Integration.ModelsSupplierApi.PaymentCondition() { PaymentConditionID = "p04", PaymentConditionType = Integration.ModelsSupplierApi.PaymentConditionType.CREDIT_CARD_MASTERCARD, Name = "Cartão de crédito Mastercard" });
                response.PaymentConditions.Add(new Integration.ModelsSupplierApi.PaymentCondition() { PaymentConditionID = "p05", PaymentConditionType = Integration.ModelsSupplierApi.PaymentConditionType.CREDIT_CARD_VISA, Name = "Cartão de crédito Visa" });
                response.PaymentConditions.Add(new Integration.ModelsSupplierApi.PaymentCondition() { PaymentConditionID = "p06", PaymentConditionType = Integration.ModelsSupplierApi.PaymentConditionType.CREDIT_CARD_DINERS, Name = "Cartão de crédito Diners" });
                response.PaymentConditions.Add(new Integration.ModelsSupplierApi.PaymentCondition() { PaymentConditionID = "p07", PaymentConditionType = Integration.ModelsSupplierApi.PaymentConditionType.CREDIT_CARD_HIPERCARD, Name = "Cartão de crédito Hipercard" });
                response.PaymentConditions.Add(new Integration.ModelsSupplierApi.PaymentCondition() { PaymentConditionID = "p08", PaymentConditionType = Integration.ModelsSupplierApi.PaymentConditionType.BANK_SLIP, Name = "Boleto Bancário" });
                
                //Formas de entrega
                response.ShippingTypes = new List<Integration.ModelsSupplierApi.ShippingType>();
                response.ShippingTypes.Add(new Integration.ModelsSupplierApi.ShippingType() { ShippingTypeID = "s01", Name = "Sedex" });
                response.ShippingTypes.Add(new Integration.ModelsSupplierApi.ShippingType() { ShippingTypeID = "s02", Name = "Motoboy" });

                //Área de entrega atendida pelo distribuidor
                response.SupplierDeliveryRestrictions = new List<Integration.ModelsSupplierApi.SupplierDeliveryRestriction>();
                response.SupplierDeliveryRestrictions.Add(new Integration.ModelsSupplierApi.SupplierDeliveryRestriction("SP", null));
                response.SupplierDeliveryRestrictions.Add(new Integration.ModelsSupplierApi.SupplierDeliveryRestriction("RS", "Porto Alegre"));
                response.SupplierDeliveryRestrictions.Add(new Integration.ModelsSupplierApi.SupplierDeliveryRestriction("RJ", "Caxias do Sul"));

                return GetResultOK(response);
            }
            catch (System.Exception ex)
            {
                string errorMessage = "Erro ao obter dados do fornecedor";
                response.AddMessage(ErrorCodes.SupplierGet_UnknownError, errorMessage);
                UtilsApi.WriteError(errorMessage, ex);
                return GetResultInternalServerError(response);
            }
        }
    }
}
