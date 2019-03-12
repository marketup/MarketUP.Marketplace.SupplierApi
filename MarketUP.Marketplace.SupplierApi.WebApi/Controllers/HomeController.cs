using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace MarketUP.Marketplace.SupplierApi.WebApi.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("")]
    public class HomeController : ApiController
    {
        //NOTA: Essa controller é utilizada somente para retornar uma página padrão ao acessar a url da API

        [Route("")]
        [HttpGet]
        public HttpResponseMessage Home()
        {
            var sb = new StringBuilder();
            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html>");
            sb.AppendLine("<head>");
            sb.AppendLine("   <meta charset=\"utf-8\" />");
            sb.AppendLine("   <title>Modelo API Fornecedor Marketplace MarketUP</title>");
            sb.AppendLine("   <script type=\"text/javascript\" src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js\"></script>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");
            sb.AppendLine("   <h1>Modelo API Fornecedor Marketplace MarketUP</h1>");
            sb.AppendLine("   <p>Documento com a especificação dos métodos <a href=\"https://integracao-marketplace.marketup.com/integracao-api-especifica\" target=\"_blank\">aqui</a></p>");
            sb.AppendLine("   <p>Código no Github <a href=\"https://github.com/marketup/MarketUP.Marketplace.SupplierApi\" target=\"_blank\">aqui</a></p>");
            sb.AppendLine("   <p>Documentação Swagger dessa implementação <a href=\"/swagger\" target=\"_blank\">aqui</a></p>");
            sb.AppendLine("   <p>Para testar com o <a href=\"https://www.getpostman.com/downloads/\" target=\"_blank\">Postman</a>, importar a coleção:<br />https://www.getpostman.com/collections/b57f42309ea61d050609</p>");
            sb.AppendLine("</body>");
            sb.AppendLine("</html>");

            string html = sb.ToString();

            var response = new HttpResponseMessage();
            response.Content = new StringContent(html);
            response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/html");
            return response;
        }
    }
}
