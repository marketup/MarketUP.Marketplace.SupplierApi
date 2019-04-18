using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class InvoiceInformation
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("serie")]
        public string Serie { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("issuanceDate")]
        public DateTime? IssuanceDate { get; set; }

        [JsonProperty("urlXml")]
        public string UrlXml { get; set; }

        [JsonProperty("urlPdf")]
        public string UrlPdf { get; set; }
    }
}
