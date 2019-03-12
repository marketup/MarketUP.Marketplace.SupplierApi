using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace MarketUP.Marketplace.SupplierApi.WebApi.Controllers
{
    [RoutePrefix("")]
    public class HomeController : ApiController
    {
        //NOTA: Essa controller é utilizada somente para retornar uma página padrão ao acessar a url da API

        [Route("")]
        [HttpGet]
        public HttpResponseMessage Home()
        {
            var sb = new StringBuilder();
            sb.AppendLine("<html>");
            sb.AppendLine("<head>");
            sb.AppendLine("   <title>Modelo API Fornecedor Marketplace MarketUP</title>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");
            sb.AppendLine("   <h1>Modelo API Fornecedor Marketplace MarketUP</h1>");
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
