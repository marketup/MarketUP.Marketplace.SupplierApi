using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace MarketUP.Marketplace.SupplierApi.WebApi.Controllers
{
    public abstract class BaseApiController : ApiController
    {
        /// <summary>
        /// Success 200 - OK
        /// </summary>
        public CustomActionResult<T> GetResultOK<T>(T content) where T : Integration.ModelsSupplierApi.BaseResponse
        {
            return new CustomActionResult<T>(Request, HttpStatusCode.OK, content);
        }
        
        /// <summary>
        /// Created 201 - OK
        /// </summary>
        public CustomActionResult<T> GetResultCreated<T>(T content) where T : Integration.ModelsSupplierApi.BaseResponse
        {
            return new CustomActionResult<T>(Request, HttpStatusCode.Created, content);
        }

        /// <summary>
        /// Erro 400 - BadRequest
        /// </summary>
        public CustomActionResult<T> GetResultBadRequest<T>(T content) where T : Integration.ModelsSupplierApi.BaseResponse
        {
            return new CustomActionResult<T>(Request, HttpStatusCode.BadRequest, content);
        }

        /// <summary>
        /// Erro 404 - recurso não encontrado
        /// </summary>
        public CustomActionResult<T> GetResultNotFound<T>(T content) where T : Integration.ModelsSupplierApi.BaseResponse
        {
            return new CustomActionResult<T>(Request, HttpStatusCode.NotFound, content);
        }

        /// <summary>
        /// Erro 401 - Unauthorized - usuário não está logado
        /// </summary>
        public CustomActionResult<T> GetResultUnauthorized<T>(T content) where T : Integration.ModelsSupplierApi.BaseResponse
        {
            return new CustomActionResult<T>(Request, HttpStatusCode.Unauthorized, content);
        }

        /// <summary>
        /// Erro 500 - InternalServerError - Erro interno no servidor (exception)
        /// </summary>
        public CustomActionResult<T> GetResultInternalServerError<T>(T content) where T : Integration.ModelsSupplierApi.BaseResponse
        {
            return new CustomActionResult<T>(Request, HttpStatusCode.InternalServerError, content);
        }
    }
}