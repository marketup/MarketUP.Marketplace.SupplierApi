using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class Client
    {
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

        [JsonProperty("ClientID")]
        public string ClientID { get; set; }

        public Client()
        {

        }

        public Client(string companyName, string cnpj, string ie, string email,  string phone, string contactFirstName, string contactLastName, string contactCpf,Address billingAddress, string clientID)
        {
            this.CompanyName = companyName;
            this.Cnpj = cnpj;
            this.Ie = ie;
            this.Email = email;
            this.Phone = phone;
            this.ContactFirstName = contactFirstName;
            this.ContactLastName = contactLastName;
            this.ContactCpf = contactCpf;
            this.BillingAddress = billingAddress;
            this.ClientID = clientID;
        }
    }
}
