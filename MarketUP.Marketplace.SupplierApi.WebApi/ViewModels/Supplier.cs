using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class Supplier : BaseResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("companyOfficialName")]
        public string CompanyOfficialName { get; set; }

        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty("ie")]
        public string Ie { get; set; }

        [JsonProperty("integrationNotificationEmail")]
        public string IntegrationNotificationEmail { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("shippingTypes")]
        public List<ShippingType> ShippingTypes { get; set; }

        [JsonProperty("paymentConditions")]
        public List<PaymentCondition> PaymentConditions { get; set; }

        [JsonProperty("supplierDeliveryRestrictions")]
        public List<SupplierDeliveryRestriction> SupplierDeliveryRestrictions { get; set; }

        [JsonProperty("aboutText")]
        public string AboutText { get; set; }

        [JsonProperty("policyText")]
        public string PolicyText { get; set; }

        [JsonProperty("usePayFaster")]
        public bool UsePayFaster { get; set; }

        [JsonProperty("clientRegisterRequired")]
        public bool ClientRegisterRequired { get; set; }

        [JsonProperty("useFixedDeliveryAddress")]
        public bool UseFixedDeliveryAddress { get; set; }

        public Supplier()
        {

        }

        public Supplier(string name,
            string companyOfficialName,
            string cnpj,
            string ie,
            string integrationNotificationEmail,
            string phone,
            string email,
            Address address,
            bool marketplaceIntegrationVisible,
            bool marketplaceIntegrationActive,
            List<ShippingType> shippingTypes,
            List<PaymentCondition> paymentConditions,
            List<SupplierDeliveryRestriction> supplierDeliveryRestrictions,
            string aboutText,
            string policyText,
            bool usePayFaster,
            bool clientRegisterRequired,
            bool useFixedDeliveryAddress
            )
        {
            this.Name = name;
            this.CompanyOfficialName = companyOfficialName;
            this.Cnpj = cnpj;
            this.Ie = ie;
            this.IntegrationNotificationEmail = integrationNotificationEmail;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            this.ShippingTypes = shippingTypes;
            this.PaymentConditions = paymentConditions;
            this.SupplierDeliveryRestrictions = supplierDeliveryRestrictions;

            this.AboutText = aboutText;
            this.PolicyText = policyText;

            this.UsePayFaster = usePayFaster;
            this.ClientRegisterRequired = clientRegisterRequired;
            this.UseFixedDeliveryAddress = useFixedDeliveryAddress;
        }
    }
}
