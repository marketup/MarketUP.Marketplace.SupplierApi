using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MarketUP.Marketplace.SupplierApi.WebApi.Controllers
{
    [RoutePrefix("products")]
    public class ProductController : BaseApiController
    {
        [Route(""), HttpGet]
        public CustomActionResult<Integration.ModelsSupplierApi.ProductListResponse> List(int page = 1, int pageSize = 20)
        {
            var response = new Integration.ModelsSupplierApi.ProductListResponse();

            try
            {
                if (page < 1)
                {
                    response.AddMessage(ErrorCodes.ProductList_InvalidPage, "Número de página inválido");
                    return GetResultBadRequest(response);
                }

                //TODO: Trazer do banco de dados uma lista paginada dos ids dos produtos
                var products = new List<Integration.ModelsSupplierApi.ProductReference>();
                for (int i=1; i<=105; i++)
                    products.Add(new Integration.ModelsSupplierApi.ProductReference((1000 + i).ToString())); //Gera uma lista com exemplos
                var ordenedList = products.OrderBy(a => a.ProductID);
                var pagedList = new Models.PagedList<Integration.ModelsSupplierApi.ProductReference>(page, pageSize, ordenedList);

                var previousUrl = (page == 1 ? null : string.Format("/products?page={0}&pageSize={1}", (page-1 <= pagedList.TotalPages ? page -1 : pagedList.TotalPages), pageSize));
                var nextUrl = (page >= pagedList.TotalPages ? null : string.Format("/products?page={0}&pageSize={1}", page + 1, pageSize));

                response.Products = pagedList.Items;
                response.Paging = new Integration.ModelsSupplierApi.Paging(pagedList.Page, pagedList.ItemsPage, pagedList.TotalPages, pagedList.TotalItems, previousUrl, nextUrl);

                return GetResultOK(response);
            }
            catch (System.Exception ex)
            {
                string errorMessage = "Erro ao listar produtos";
                response.AddMessage(ErrorCodes.ProductList_UnknownError, errorMessage, ex.GetFullExceptionMessage());
                UtilsApi.WriteError(errorMessage, ex, string.Format("page={0}, pageSize={1}", page, pageSize));
                return GetResultInternalServerError(response);
            }
        }
    }
}