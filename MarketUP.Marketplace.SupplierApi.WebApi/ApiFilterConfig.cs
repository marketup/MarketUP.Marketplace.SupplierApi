using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MarketUP.Marketplace.SupplierApi.WebApi
{
    public static class ApiFilterConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Força uso de https
            config.Filters.Add(new Filters.RequireHttpsFilter());

            //valida header Authorization
            config.Filters.Add(new Filters.AuthorizationFilter());
        }
    }
}