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

        public const int TokenGet_UnknownError = 1001;
        public const int TokenGet_InvalidGrantType = 1002;
        public const int TokenGet_InvalidCredential = 1003;

        public const int SupplierGet_UnknownError = 2001;

        public const int ClientRegister_UnknownError = 3001;
        public const int ClientRegister_InvalidCompanyName = 3002;
        public const int ClientRegister_InvalidCnpj = 3003;
        public const int ClientRegister_InvalidEmail = 3004;
        public const int ClientRegister_InvalidBillingAddress = 3005;
        public const int ClientRegister_InvalidBillingAddress_Zipcode = 3006;
        public const int ClientRegister_InvalidBillingAddress_Address = 3007;
        public const int ClientRegister_InvalidBillingAddress_Quarter = 3008;
        public const int ClientRegister_InvalidBillingAddress_City = 3009;
        public const int ClientRegister_InvalidBillingAddress_State = 3010;

        public const int ClientGetRegisterStatus_UnknownError = 3101;
        public const int ClientGetRegisterStatus_RegisterKeyEmpty = 3102;
        public const int ClientGetRegisterStatus_ClientRejected = 3103;
        public const int ClientGetRegisterStatus_RegisterKeyNotFound = 3104;

        public const int ClientGet_UnknownError = 3201;
        public const int ClientGet_ClientIdEmpty = 3202;
        public const int ClientGet_ClientNotFound = 3203;

        public const int ClientUpdate_UnknownError = 3201;
        public const int ClientUpdate_ClientIdEmpty = 3202;
        public const int ClientUpdate_ClientNotFound = 3203;
    }
}