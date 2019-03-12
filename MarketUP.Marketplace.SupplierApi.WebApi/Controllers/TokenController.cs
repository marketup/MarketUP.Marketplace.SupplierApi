using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MarketUP.Marketplace.SupplierApi.WebApi.Controllers
{
    [RoutePrefix("token")]
    public class TokenController : BaseApiController
    {
        [AllowAnonymous]
        [Route(""), HttpPost]
        public CustomActionResult<Integration.ModelsSupplierApi.TokenGetResponse> Post(Integration.ModelsSupplierApi.TokenGetRequest request)
        {
            var response = new Integration.ModelsSupplierApi.TokenGetResponse();

            try
            {
                if (request == null)
                {
                    response.AddMessage(ErrorCodes.RequestNull, "Request null");
                    return GetResultBadRequest(response);
                }

                if (string.IsNullOrEmpty(request.grant_type))
                {
                    response.AddMessage(ErrorCodes.TokenInvalidGrantType, "Parâmetro \"grant_type\" não preenchido");
                    return GetResultBadRequest(response);
                }
                
                if (request.grant_type.Equals("password", StringComparison.CurrentCultureIgnoreCase))
                {
                    if (string.IsNullOrEmpty(request.username))
                        response.AddMessage(ErrorCodes.ParameterEmpty, "Parâmetro \"usuername\" não preenchido");

                    if (string.IsNullOrEmpty(request.password))
                        response.AddMessage(ErrorCodes.ParameterEmpty, "Parâmetro \"password\" não preenchido");

                    if (response.Messages != null && response.Messages.Count > 0)
                        return GetResultBadRequest(response);

                    //TODO: Substituir essa senha padrão por alguma senha mais forte
                    if (string.Equals(request.username, "ti@marketup.com", StringComparison.CurrentCultureIgnoreCase) 
                        && string.Equals(request.password, "teste@2529")
                    )
                    {
                        //TODO: Criar processo para gerar o token
                        // 1- Gerar um novo token (ex: Guid.NewGuid().ToString().ToLower()) 
                        // 2- Gravar no Banco de dados
                        // 3- Alterar classe "Filters/AuthorizationFilter.cs" para validar esse token

                        var token = UtilsApi.TOKEN_TEST;

                        response.TokenType = "bearer";
                        response.AccessToken = token;
                        response.ExpireInSeconds = 2 * 60 * 60; //2 horas
                    }
                    else
                    {
                        response.AddMessage(ErrorCodes.TokenInvalidCredential, "E-mail ou senha inválidos");
                        return GetResultUnauthorized(response);
                    }
                }
                else
                {
                    response.AddMessage(ErrorCodes.TokenInvalidGrantType, "Parâmetro \"grant_type\" inválido");
                    return GetResultBadRequest(response);
                }

                return GetResultOK(response);
            }
            catch (System.Exception ex)
            {
                string errorMessage = "Erro ao gerar o token de autenticação";
                response.AddMessage(ErrorCodes.TokenUnknownError, errorMessage);
                UtilsApi.WriteError(errorMessage, ex);
                return GetResultInternalServerError(response);
            }
        }
    }
}