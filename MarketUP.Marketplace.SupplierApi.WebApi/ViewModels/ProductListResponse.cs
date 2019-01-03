using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class ProductListResponse : BaseResponse
    {
        public List<ProductReference> Products { get; set; }

        public Paging Paging { get; set; }

        public ProductListResponse()
        {

        }

        public ProductListResponse(List<ProductReference> products, Paging paging)
        {
            this.Products = products;
            this.Paging = paging;
        }
    }
}
