using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class TokenGetRequest
    {
        public string grant_type { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public TokenGetRequest()
        {

        }

        public TokenGetRequest(string grantType, string username, string password)
        {
            this.grant_type = grantType;
            this.username = username;
            this.password = password;
        }
    }
}
