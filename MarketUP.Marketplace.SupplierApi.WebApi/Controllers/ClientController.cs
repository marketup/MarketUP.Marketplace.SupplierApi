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
                if (string.IsNullOrEmpty(request.CompanyName))
                    response.AddMessage("400-050", "Nome da empresa não preenchido");

                if (string.IsNullOrEmpty(request.Email))
                    response.AddMessage("400-100", "E-mail não preenchido");
                else if (!new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*").Match(request.Email).Success)
                    response.AddMessage("400-101", "Email inválido");

                if (string.IsNullOrEmpty(request.BillingAddress.Zipcode))
                    response.AddMessage("400-110", "CEP não preenchido");
                
                //TODO: Validar os outros campos

                if (response.Messages != null && response.Messages.Count > 0)
                    return this.GetResultBadRequest(response);
                
                //TODO: Remove essa condição e deixar somente o modelo que você irá utilizar sincrono/asincrono
                var isSynchronous = false;
                if (isSynchronous)
                {
                    //-- Modelo sincrono

                    //TODO: Gravar o cliente

                    //TODO: Substituir pelo ID do cliente
                    response.ClientID = "mp55999";
                    response.UrlClient = string.Format("/clients/{0}", response.ClientID);
                    
                    //TODO: Se o cliente já existir, retornar o ID do cliente existente
                    //return this.GetResultOK(response);

                    return this.GetResultCreated(response);
                }
                else
                {
                    //-- Modelo asincrono

                    //TODO: Gravar a requisição do cadastro

                    //TODO: Se o cliente já existir, retornar o ID do cliente existente
                    //response.ClientID = "mp55999";
                    //response.UrlClient = string.Format("/clients/{0}", response.ClientID);
                    //return this.GetResultOK(response);

                    response.RegisterKey = "da3c07a7446c43f0886d7705703127e3";
                    response.UrlCheckStatus = string.Format("/clients/register-status/{0}", response.RegisterKey);
                    //TODO: Substituir pelo ID da requisição do registro

                    return this.GetResultAccepted(response);
                }
            }
            catch (System.Exception ex)
            {
                string errorMessage = "Erro no cadastro de cliente";
                response.AddMessage("500-2453", errorMessage);
                UtilsApi.WriteError(errorMessage, ex);
                return this.GetResultInternalServerError(response);
            }
        }
    }
}
