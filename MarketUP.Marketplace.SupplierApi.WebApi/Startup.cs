using Microsoft.Owin;
using Newtonsoft.Json.Serialization;
using Owin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

[assembly: OwinStartup(typeof(MarketUP.Marketplace.SupplierApi.WebApi.Startup))]
namespace MarketUP.Marketplace.SupplierApi.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            //Enable CORS
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            ConfigureApi(app, config);
        }

        private void ConfigureApi(IAppBuilder app, HttpConfiguration config)
        {
            app.UseWebApi(config);
            
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;

            config.Formatters.Add(new BrowserJsonFormatter());
            config.Formatters.Add(new AjaxJsonFormatter());

            ApiFilterConfig.Register(config);
            ApiRouteConfig.Register(config);
        }

        private class AjaxJsonFormatter : JsonMediaTypeFormatter
        {
            public AjaxJsonFormatter()
            {
                this.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();
                this.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            }
        }

        private class BrowserJsonFormatter : JsonMediaTypeFormatter
        {
            public BrowserJsonFormatter()
            {
                this.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
                this.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
                this.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();
                this.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;

                this.SupportedEncodings.Add(new UTF8Encoding(encoderShouldEmitUTF8Identifier: true));
                this.SupportedEncodings.Add(Encoding.GetEncoding("UTF-8"));
            }

            public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
            {
                base.SetDefaultContentHeaders(type, headers, mediaType);
                headers.ContentType = new MediaTypeHeaderValue("application/json");
            }

            public override void WriteToStream(Type type, object value, Stream writeStream, Encoding effectiveEncoding)
            {
                effectiveEncoding = Encoding.GetEncoding("UTF-8");
                base.WriteToStream(type, value, writeStream, effectiveEncoding);
            }
        }
    }
}