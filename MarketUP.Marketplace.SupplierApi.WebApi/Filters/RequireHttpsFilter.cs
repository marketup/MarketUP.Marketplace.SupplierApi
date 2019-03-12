using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;

namespace MarketUP.Marketplace.SupplierApi.WebApi.Filters
{
    /// <summary>
    /// Require Https
    /// </summary>
    public class RequireHttpsFilter : System.Web.Http.Filters.AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            /*try
            {
                if (actionContext.Request.RequestUri.Scheme == Uri.UriSchemeHttps)
                {
                    base.OnAuthorization(actionContext);
                    return;
                }

                var response = new Integration.ModelsSupplierApi.BaseResponse();
                response.AddMessage(ErrorCodes.HttpsRequired, "Https required");

                actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Forbidden)
                {
                    ReasonPhrase = "HTTPS Required",
                    Content = new System.Net.Http.StringContent(UtilsApi.JsonSerialize(response, true, true), System.Text.Encoding.UTF8, "application/json")
                };
            }
            catch (System.Exception ex)
            {
                UtilsApi.WriteError(string.Format("Erro no RequireHttpsFilter -- {0}", ex.Message), ex);
            }*/

            base.OnAuthorization(actionContext);
        }
    }
}