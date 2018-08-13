using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MarketUP.Marketplace.SupplierApi.WebApi.Controllers
{
    [RoutePrefix("shipping-types")]
    public class ShippingTypesController : BaseApiController
    {
        [Route(""), HttpGet]
        public CustomActionResult<Integration.ModelsSupplierApi.ShippingTypeListResponse> List()
        {
            var response = new Integration.ModelsSupplierApi.ShippingTypeListResponse();

            try
            {
                response.ShippingTypes = new List<Integration.ModelsSupplierApi.ShippingType>();

                response.ShippingTypes.Add(new Integration.ModelsSupplierApi.ShippingType() { ShippingTypeID = "s01", Name = "Sedex" });
                response.ShippingTypes.Add(new Integration.ModelsSupplierApi.ShippingType() { ShippingTypeID = "s02", Name = "Motoboy" });

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
