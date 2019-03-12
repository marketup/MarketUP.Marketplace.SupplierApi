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
                string errorMessage = "Erro no cadastro de cliente";
                response.AddMessage(ErrorCodes.ClientRegister_UnknownError, errorMessage);
                UtilsApi.WriteError(errorMessage, ex);
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
                string errorMessage = "Erro no cadastro de cliente";
                response.AddMessage(ErrorCodes.ClientGetRegisterStatus_UnknownError, errorMessage);
                UtilsApi.WriteError(errorMessage, ex);
                return GetResultInternalServerError(response);
            }
        }

        /*public CustomActionResult<Integration.ModelsSupplierApi.ClientGetResponse> Get()
        {

        }*/
    }
}
