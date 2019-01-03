using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class ProductImage
    {
        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        public ProductImage()
        {

        }

        public ProductImage(string imageUrl)
        {
            this.ImageUrl = imageUrl;
        }
    }
}
