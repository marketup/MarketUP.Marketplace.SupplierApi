using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketUP.Marketplace.SupplierApi.WebApi
{
    public static class ErrorCodes
    {
        //TODO: Você pode implementar qualquer número de código de erro, os códigos são referências para você tratar os erros que são recebidos da API do Marketplace, mas não são usados pelo Marketplace

        public const int HttpsRequired = 9;
        public const int Unauthorized = 10;
        public const int RequestNull = 11;
        public const int ParameterEmpty = 12;

        public const int TokenUnknownError = 1001;
        public const int TokenInvalidGrantType = 1002;
        public const int TokenInvalidCredential = 1003;

        public const int SupplierGetUnknownError = 2001;

        public const int ClientGetUnknownError = 3001;
    }
}