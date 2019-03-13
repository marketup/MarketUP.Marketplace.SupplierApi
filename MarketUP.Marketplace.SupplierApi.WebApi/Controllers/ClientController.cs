using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MarketUP.Marketplace.SupplierApi.WebApi.Controllers
{
    [RoutePrefix("clients")]
    public class ClientController : BaseApiController
    {
        [Route(""), HttpPost]
        public CustomActionResult<Integration.ModelsSupplierApi.ClientRegisterResponse> Register(Integration.ModelsSupplierApi.ClientRegisterRequest request)
        {
            var response = new Integration.ModelsSupplierApi.ClientRegisterResponse();

            try
            {
                if (request == null)
                {
                    response.AddMessage(ErrorCodes.RequestNull, "Request null");
                    return GetResultBadRequest(response);
                }

                if (string.IsNullOrEmpty(request.CompanyName))
                    response.AddMessage(ErrorCodes.ClientRegister_InvalidCompanyName, "Nome da empresa não preenchido");

                if (string.IsNullOrEmpty(request.Cnpj))
                    response.AddMessage(ErrorCodes.ClientRegister_InvalidCnpj, "Cnpj da empresa não preenchido");

                if (string.IsNullOrEmpty(request.Email))
                    response.AddMessage(ErrorCodes.ClientRegister_InvalidEmail, "E-mail não preenchido");
                else if (!new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*").Match(request.Email).Success)
                    response.AddMessage(ErrorCodes.ClientRegister_InvalidEmail, "Email inválido");

                if (request.BillingAddress == null)
                    response.AddMessage(ErrorCodes.ClientRegister_InvalidBillingAddress, "Endereço de faturamento não preenchido");
                else
                {
                    if (string.IsNullOrEmpty(request.BillingAddress.Zipcode))
                        response.AddMessage(ErrorCodes.ClientRegister_InvalidBillingAddress_Zipcode, "CEP do endereço de faturamento não preenchido");

                    if (string.IsNullOrEmpty(request.BillingAddress.Street))
                        response.AddMessage(ErrorCodes.ClientRegister_InvalidBillingAddress_Address, "Logradouro do endereço de faturamento não preenchido");

                    if (string.IsNullOrEmpty(request.BillingAddress.Quarter))
                        response.AddMessage(ErrorCodes.ClientRegister_InvalidBillingAddress_Quarter, "Bairro do endereço de faturamento não preenchido");

                    if (string.IsNullOrEmpty(request.BillingAddress.City))
                        response.AddMessage(ErrorCodes.ClientRegister_InvalidBillingAddress_City, "Cidade do endereço de faturamento não preenchido");

                    if (string.IsNullOrEmpty(request.BillingAddress.State))
                        response.AddMessage(ErrorCodes.ClientRegister_InvalidBillingAddress_State, "UR do endereço de faturamento não preenchido");
                }

                if (response.Messages != null && response.Messages.Count > 0)
                    return GetResultBadRequest(response);

                //TODO: Remover essa condição e deixar somente o modelo que você irá utilizar síncrono/asíncrono
                bool useAsyncMode = true;
                if (!useAsyncMode)
                {
                    //-- Modelo síncrono

                    //TODO: Consultar no Banco de dados, se o cliente já existir, retornar o ID do cliente existente
                    if (string.Equals(request.Cnpj, "13998916000124"))
                    {
                        //-- Cliente já está cadastrado

                        //TODO: Retornar o ID do cliente no seu Banco de dados

                        response.ClientID = "cli0001";
                        response.UrlClient = string.Format("/clients/{0}", response.ClientID);
                        return GetResultOK(response);
                    }
                    else
                    {
                        //--- Cadastrar cliente

                        //TODO: Gravar o cliente

                        //TODO: Retornar o ID do cliente no seu Banco de dados
                        response.ClientID = "cli0001";
                        response.UrlClient = string.Format("/clients/{0}", response.ClientID);

                        return GetResultCreated(response);
                    }
                }
                else
                {
                    //-- Modelo asíncrono

                    //TODO: Consultar no Banco de dados, se o cliente já existir, retornar o ID do cliente existente
                    if (string.Equals(request.Cnpj, "13998916000124"))
                    {
                        //-- Cliente já está cadastrado

                        //TODO: Retornar o ID do cliente no seu Banco de dados
                        response.ClientID = "cli0001";
                        response.UrlClient = string.Format("/clients/{0}", response.ClientID);
                        return GetResultOK(response);
                    }
                    else
                    {
                        //TODO: Incluir o cliente na fila para cadastro com o RegisterKey gerado

                        response.RegisterKey = Guid.NewGuid().ToString("N").ToLower();
                        response.UrlCheckStatus = string.Format("/clients/register-status/{0}", response.RegisterKey);

                        return GetResultAccepted(response);
                    }
                }
            }
            catch (System.Exception ex)
            {
                string errorMessage = "Erro ao cadastrar cliente";
                response.AddMessage(ErrorCodes.ClientRegister_UnknownError, errorMessage, ex.GetFullExceptionMessage());
                UtilsApi.WriteError(errorMessage, ex, string.Format("Request={0}", UtilsApi.JsonSerialize(request)));
                return GetResultInternalServerError(response);
            }
        }

        [Route("register-status/{registerKey}")]
        public CustomActionResult<Integration.ModelsSupplierApi.ClientRegisterResponse> GetRegisterStatus(string registerKey)
        {
            var response = new Integration.ModelsSupplierApi.ClientRegisterResponse();

            try
            {
                if (string.IsNullOrEmpty(registerKey))
                {
                    response.AddMessage(ErrorCodes.ClientGetRegisterStatus_RegisterKeyEmpty, "Chave de registro não fornecida");
                    return GetResultBadRequest(response);
                }

                //TODO: Pesquisar registro da solicitação de cadastro na Fila

                if (registerKey.Equals("111111111111", StringComparison.CurrentCultureIgnoreCase))
                {
                    //---- Se a solicitação de cadastro ainda não foi processada

                    //TODO: Implementar condição em que o cadastro ainda não foi processado
                    response.UrlCheckStatus = string.Format("/clients/register-status/{0}", registerKey);
                    return GetResultAccepted(response);
                }
                else if(registerKey.Equals("222222222222", StringComparison.CurrentCultureIgnoreCase))
                {
                    //---- Cadastro Aprovado

                    //TODO: Retornar o ID do cliente no seu Banco de dados
                    response.ClientID = "cli0001";
                    response.UrlClient = string.Format("/clients/{0}", response.ClientID);
                    return GetResultOK(response);
                }
                else if (registerKey.Equals("333333333333", StringComparison.CurrentCultureIgnoreCase))
                {
                    //---- Cadastro Reprovado
                    response.AddMessage(ErrorCodes.ClientGetRegisterStatus_ClientRejected, "Cliente não aprovado, entre em contato pelo telefone xxxx-xxxx");
                    return GetResultBadRequest(response);
                }
                else
                {
                    //---- Chave de registro não encontrada
                    response.AddMessage(ErrorCodes.ClientGetRegisterStatus_RegisterKeyNotFound, "Chave de registro não encontrada");
                    return GetResultNotFound(response);
                }
            }
            catch (System.Exception ex)
            {
                string errorMessage = "Erro ao consultar o status da chave de registro do cliente";
                response.AddMessage(ErrorCodes.ClientGetRegisterStatus_UnknownError, errorMessage, ex.GetFullExceptionMessage());
                UtilsApi.WriteError(errorMessage, ex, string.Format("RegisterKey={0}", registerKey));
                return GetResultInternalServerError(response);
            }
        }

        [Route("{clientID}"), HttpGet]
        public CustomActionResult<Integration.ModelsSupplierApi.ClientGetResponse> Get(string clientID)
        {
            var response = new Integration.ModelsSupplierApi.ClientGetResponse();

            try
            {
                if (string.IsNullOrEmpty(clientID))
                {
                    response.AddMessage(ErrorCodes.ClientGet_ClientIdEmpty, "Parâmetro ClientID não preenchido");
                    return GetResultBadRequest(response);
                }

                //TODO: Consultar o cliente no seu banco de dados
                if (clientID.Equals("cli0001"))
                {
                    var deliveryAddressList = new List<Integration.ModelsSupplierApi.DeliveryAddress>();
                    deliveryAddressList.Add(new Integration.ModelsSupplierApi.DeliveryAddress("Casa", "Eduardo Coutinho", "Av. Angélica", "2529", null, "Bela Vista", "01227200", "São Paulo", "SP", "Brasil"));

                    var billingAddress = new Integration.ModelsSupplierApi.Address("Av. Angélica", "2529", null, "Bela Vista", "01227200", "São Paulo", "SP", "Brasil");

                    var clientPaymentConditionsList = new List<Integration.ModelsSupplierApi.ClientPaymentCondition>();
                    clientPaymentConditionsList.Add(new Integration.ModelsSupplierApi.ClientPaymentCondition("p01", 100, 500));
                    clientPaymentConditionsList.Add(new Integration.ModelsSupplierApi.ClientPaymentCondition("p02", 100, null));

                    response = new Integration.ModelsSupplierApi.ClientGetResponse("cli0001",
                        "NUVEMSIS PARTICIPAÇÕES LTDA",
                        "13998916000124",
                        "142851418117",
                        "ti@marketup.com",
                        "(11) 3895-7038",
                        "Eduardo",
                        "Coutinho",
                        "13632749370",
                        billingAddress,
                        deliveryAddressList,
                        "active",
                        null,
                        clientPaymentConditionsList);

                    return GetResultOK(response);
                }
                else
                {
                    response.AddMessage(ErrorCodes.ClientGet_ClientIdEmpty, "Cliente não encontrado");
                    return GetResultNotFound(response);
                }
            }
            catch (System.Exception ex)
            {
                string errorMessage = "Erro ao consultar cliente";
                response.AddMessage(ErrorCodes.ClientGet_UnknownError, errorMessage, ex.GetFullExceptionMessage());
                UtilsApi.WriteError(errorMessage, ex, string.Format("ClientID={0}", clientID));
                return GetResultInternalServerError(response);
            }
        }

        [Route("{clientID}"), HttpPost]
        public CustomActionResult<Integration.ModelsSupplierApi.ClientUpdateResponse> Update(string clientID, Integration.ModelsSupplierApi.ClientUpdateRequest request)
        {
            var response = new Integration.ModelsSupplierApi.ClientUpdateResponse();

            try
            {
                if (string.IsNullOrEmpty(clientID))
                {
                    response.AddMessage(ErrorCodes.ClientUpdate_ClientIdEmpty, "Parâmetro ClientID não preenchido");
                    return GetResultBadRequest(response);
                }

                //TODO: Consultar o cliente no seu banco de dados
                if (clientID.Equals("cli0001"))
                {
                    //TODO: Atualizar o registro

                    var deliveryAddressList = new List<Integration.ModelsSupplierApi.DeliveryAddress>();
                    deliveryAddressList.Add(new Integration.ModelsSupplierApi.DeliveryAddress("Casa", "Eduardo Coutinho", "Av. Angélica", "2529", null, "Bela Vista", "01227200", "São Paulo", "SP", "Brasil"));

                    var billingAddress = new Integration.ModelsSupplierApi.Address("Av. Angélica", "2529", null, "Bela Vista", "01227200", "São Paulo", "SP", "Brasil");

                    var clientPaymentConditionsList = new List<Integration.ModelsSupplierApi.ClientPaymentCondition>();
                    clientPaymentConditionsList.Add(new Integration.ModelsSupplierApi.ClientPaymentCondition("p01", 100, 500));
                    clientPaymentConditionsList.Add(new Integration.ModelsSupplierApi.ClientPaymentCondition("p02", 100, null));

                    response = new Integration.ModelsSupplierApi.ClientUpdateResponse("cli0001",
                        "NUVEMSIS PARTICIPAÇÕES LTDA",
                        "13998916000124",
                        "142851418117",
                        "ti@marketup.com",
                        "(11) 3895-7038",
                        "Eduardo",
                        "Coutinho",
                        "13632749370",
                        billingAddress,
                        deliveryAddressList,
                        "active",
                        null,
                        clientPaymentConditionsList);

                    return GetResultOK(response);
                }
                else
                {
                    response.AddMessage(ErrorCodes.ClientUpdate_ClientIdEmpty, "Cliente não encontrado");
                    return GetResultNotFound(response);
                }
            }
            catch (System.Exception ex)
            {
                string errorMessage = "Erro ao atualizar cliente";
                response.AddMessage(ErrorCodes.ClientUpdate_UnknownError, errorMessage, ex.GetFullExceptionMessage());
                UtilsApi.WriteError(errorMessage, ex, string.Format("Request={0}", UtilsApi.JsonSerialize(request)));
                return GetResultInternalServerError(response);
            }
        }
    }
}
