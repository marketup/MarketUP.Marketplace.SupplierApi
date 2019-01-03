using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class GetTokenResponse : BaseResponse
    {
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("expires_in")]
        public int? ExpireInSeconds { get; set; }

        public GetTokenResponse()
        {

        }

        public GetTokenResponse(string tokenType, string accessToken, int? expireInSeconds)
        {
            this.TokenType = tokenType;
            this.AccessToken = accessToken;
            this.ExpireInSeconds = expireInSeconds;
        }
    }
}
