using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketUP.Marketplace.SupplierApi.WebApi
{
    public static class UtilsApi
    {
        public const string HTTP_CONTEXT_ITEM_AUTH_SESSION = "AuthSession";

        public static void WriteError(string message, System.Exception ex = null)
        {
            //TODO: Log error

            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}