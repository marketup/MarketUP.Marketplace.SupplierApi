using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace MarketUP.Marketplace.SupplierApi.WebApi
{
    public class CustomActionResult<T> : IHttpActionResult
    {
        HttpRequestMessage HttpRequestMessage { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
        public T Content { get; set; }

        public string FileName { get; set; }
        public byte[] FileByteArray { get; set; }
        public string ContentType { get; set; }
        
        public CustomActionResult(HttpRequestMessage request,
            HttpStatusCode httpStatusCode,
            T content)
        {
            this.HttpRequestMessage = request;
            this.HttpStatusCode = httpStatusCode;
            this.Content = content;
        }

        public CustomActionResult(HttpRequestMessage request,
            string fileName,
            byte[] fileByteArray,
            string contentType)
        {
            if (request == null) throw new System.ArgumentException(nameof(request));
            if (string.IsNullOrWhiteSpace(fileName)) throw new System.ArgumentException(nameof(fileName));
            if (fileByteArray == null) throw new System.ArgumentException(nameof(fileByteArray));

            this.HttpRequestMessage = request;
            this.HttpStatusCode = HttpStatusCode.OK;

            this.FileName = fileName;
            this.FileByteArray = fileByteArray;
            this.ContentType = contentType;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = this.HttpRequestMessage.CreateResponse(this.HttpStatusCode, this.Content);
            return Task.FromResult(response);
        }
    }
}