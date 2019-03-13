using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketUP.Marketplace.SupplierApi.WebApi
{
    public static class UtilsApi
    {
        public const string HTTP_CONTEXT_ITEM_AUTH_SESSION = "AuthSession";
        public const string TOKEN_TEST = "00000000000000000000000000000000";
        
        public static void WriteError(string message, System.Exception ex = null, string additionalInformation = null)
        {
            //TODO: Log error

            System.Diagnostics.Debug.WriteLine(message);

            if (ex != null)
                System.Diagnostics.Debug.WriteLine(string.Format("--------\r\n{0}\r\n--------", ex.GetFullExceptionMessage()));
        }

        public static string ParseToBase64(string plainText)
        {
            if (plainText == null)
                return null;

            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string ParseFromBase64(string base64EncodedData, bool completeBase64 = false)
        {
            if (base64EncodedData == null)
                return null;

            if (completeBase64)
            {
                int mod4 = base64EncodedData.Length % 4;
                if (mod4 > 0)
                    base64EncodedData = string.Concat(base64EncodedData, new string('=', 4 - mod4));
            }

            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static string JsonSerialize(object obj, bool ignoreNull = false, bool indented = false, bool camelCase = false)
        {
            if (obj == null)
                return null;

            var settings = new Newtonsoft.Json.JsonSerializerSettings();

            if (ignoreNull)
                settings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;

            if (indented)
                settings.Formatting = Newtonsoft.Json.Formatting.Indented;

            if (camelCase)
                settings.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();

            return Newtonsoft.Json.JsonConvert.SerializeObject(obj, settings);
        }

        public static T JsonDeserialize<T>(string json)
        {
            if (string.IsNullOrEmpty(json))
                return default(T);

            var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json, new Newtonsoft.Json.Converters.IsoDateTimeConverter());
            return obj;
        }
    }
}