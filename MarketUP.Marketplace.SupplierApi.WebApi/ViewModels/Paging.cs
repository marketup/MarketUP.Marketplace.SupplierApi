using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class Paging
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        public Paging()
        {

        }

        public Paging(int page, int pageSize, int totalPages, int totalItems, string previous, string next)
        {
            this.Page = page;
            this.PageSize = pageSize;
            this.TotalPages = totalPages;
            this.TotalItems = totalItems;
            this.Previous = previous;
            this.Next = next;
        }
    }
}
