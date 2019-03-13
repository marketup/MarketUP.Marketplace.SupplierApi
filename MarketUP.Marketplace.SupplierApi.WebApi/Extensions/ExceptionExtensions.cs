using System;

namespace MarketUP.Marketplace.SupplierApi.WebApi
{
    public static class ExceptionExtensions
    {
        public static string GetFullExceptionMessage(this System.Exception ex)
        {
            if (ex == null)
                return null;

            var sb = new System.Text.StringBuilder();

            sb.AppendFormat("Message: {0}\r\n", ex.Message);

            var type = ex.GetType();
            sb.AppendFormat("Type: {0} ({1})\r\n", type.FullName, type.Assembly.FullName);

            if (!string.IsNullOrEmpty(ex.Source))
                sb.AppendFormat("Source: {0}\r\n", ex.Source);

            if (ex.TargetSite != null)
                sb.AppendFormat("TargetSite: {0}\r\n", ex.TargetSite);

            if (ex is System.ComponentModel.Win32Exception)
                sb.AppendFormat("ErrorCode: {0}\r\n", ((System.ComponentModel.Win32Exception)ex).ErrorCode);

            if (!string.IsNullOrEmpty(ex.HelpLink))
                sb.AppendFormat("HelpLink: {0}\r\n", ex.HelpLink);

            if (ex.Data != null && ex.Data.Count > 0)
            {
                sb.Append("Data:\r\n");
                foreach (System.Collections.DictionaryEntry item in ex.Data)
                    sb.AppendFormat("\t{0}\t{1}\r\n", item.Key, item.Value);
            }

            if (!string.IsNullOrEmpty(ex.StackTrace))
                sb.AppendFormat("StackTrace:\r\n---------------------------\r\n{0}\r\n---------------------------\r\n", ex.StackTrace);

            if (ex.InnerException != null)
            {
                sb.Append("\r\n>> INNER EXCEPTION:\r\n");
                sb.Append(GetFullExceptionMessage(ex.InnerException));
            }

            return sb.ToString();
        }
    }
}