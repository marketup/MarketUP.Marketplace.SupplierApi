using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Common
{
    public static class UtilsMarketplaceCommon
    {
        public static string SanitazeBarcode(string barcode)
        {
            if (string.IsNullOrWhiteSpace(barcode))
                return null;
            
            string ret = barcode.ToLower().Trim();

            //desconsidera códigos muito grandes
            if (ret.Length > 50)
                return null;

            if (!ret.StartsWith("code", StringComparison.CurrentCultureIgnoreCase))
            {
                //remove caracteres especiais
                ret = MarketUP.Library.Text.RemoveSpecialCharacters(ret, true, true, true, true);

                //remove zeros à esquerda
                var value = MarketUP.Library.Parser.ToInt64(ret);
                ret = value.ToString();

                //desconsidera códigos não numéricos
                if (value == 0)
                    return null;
                
                //tamanho deve estar entre 8 e 15 caracteres
                if (ret.Length < 8 || ret.Length > 15)
                    return null;
            }
            else
            {
                //Código gerado quando não tem barcode
                // padrão: "code-{supplierID}-{código de referencia do produto para o fornecedor}"
                // ex: "code-3-005540"
                ret = MarketUP.Library.Text.RemoveSpecialCharacters(ret, true, true, true, true, "-");
            }

            return ret;
        }

        public static string SanitazeDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                return null;

            string ret = MarketUP.Library.Text.RemoveNonVisibleCharacters(description.Trim());

            if (ret.IndexOf("<") != -1 && ret.IndexOf(">") != -1)
            {
                //Remover lixos do HTML, por exemplo, <DIV> sem tag de fechamento
                try
                {
                    //using (var memoryStream = new System.IO.MemoryStream(new UTF8Encoding(false).GetBytes(ret)))
                    //{
                    //    using (var doc = TidyManaged.Document.FromStream(memoryStream))
                    //    {
                    //        doc.InputCharacterEncoding = TidyManaged.EncodingType.Utf8;
                    //        doc.OutputBodyOnly = TidyManaged.AutoBool.Yes;
                    //        doc.Quiet = true;
                    //        doc.CleanAndRepair();
                    //        ret = doc.Save();
                    //    }
                    //}

                    var htmlDoc = new HtmlAgilityPack.HtmlDocument();
                    htmlDoc.LoadHtml(description);
                    ret = htmlDoc.DocumentNode.OuterHtml;

                    ret = ret.Replace("<br>", "<br />");
                }
                catch (System.Exception ex)
                {
                    var baseException = new System.InvalidOperationException(string.Format("Erro ao sanear o HTML da descrição do produto -- {0} -- Base64 Html: {1}", ex.Message, MarketUP.Library.Parser.ToBase64(description)), ex);
                    throw new System.InvalidOperationException(string.Format("Erro ao sanear o HTML da descrição do produto -- {0}", ex.Message), baseException);
                }
            }
            else
            {
                //text
                ret = ret.Replace("\r\n", "<br />").Replace("\r", "<br />");
            }

            return ret;
        }
    }
}
