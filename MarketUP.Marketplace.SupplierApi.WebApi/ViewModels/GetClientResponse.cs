using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class GetClientResponse
    {
        [JsonProperty("clientID")]
        public string ClientID { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty("ie")]
        public string Ie { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("contactFirstName")]
        public string ContactFirstName { get; set; }

        [JsonProperty("contactLastName")]
        public string ContactLastName { get; set; }

        [JsonProperty("contactCpf")]
        public string ContactCpf { get; set; }

        [JsonProperty("billingAddress")]
        public Address BillingAddress { get; set; }

        [JsonProperty("deliveryAddresses")]
        public List<DeliveryAddress> DeliveryAddresses { get; set; }

        [JsonProperty("clientStatus")]
        public string ClientStatus { get; set; }

        [JsonProperty("clientStatusMessage")]
        public string ClientStatusMessage { get; set; }

        [JsonProperty("paymentConditions")]
        public List<ClientPaymentCondition> PaymentConditions { get; set; }

        public GetClientResponse()
        {

        }

        public GetClientResponse(string clientID, string companyName, string cnpj, string ie, string email, string phone, string contactFirstName, string contactLastName, string contactCpf, 
            Address billingAddress, List<DeliveryAddress> deliveryAddresses,
            string clientStatus, string clientStatusMessage,
            List<ClientPaymentCondition> paymentConditions
            )
        {
            this.ClientID = clientID;
            this.Cnpj = cnpj;
            this.Ie = ie;
            this.Email = email;
            this.Phone = phone;
            this.ContactFirstName = contactFirstName;
            this.ContactLastName = contactLastName;
            this.ContactCpf = contactCpf;
            this.BillingAddress = billingAddress;
            this.DeliveryAddresses = deliveryAddresses;
            this.ClientStatus = clientStatus;
            this.ClientStatusMessage = clientStatusMessage;
            this.PaymentConditions = paymentConditions;
        }
    }
}
