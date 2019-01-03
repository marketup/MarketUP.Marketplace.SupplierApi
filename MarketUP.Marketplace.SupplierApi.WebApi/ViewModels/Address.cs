using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class Address
    {
        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("complement")]
        public string Complement { get; set; }

        [JsonProperty("quarter")]
        public string Quarter { get; set; }

        [JsonProperty("zipcode")]
        public string Zipcode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        public Address()
        {

        }

        public Address(string street, string number, string complement, string quarter,  string zipcode, string city, string state, string country)
        {
            this.Street = street;
            this.Number = number;
            this.Complement = complement;
            this.Quarter = quarter;
            this.Zipcode = zipcode;
            this.City = city;
            this.State = state;
            this.Country = country;
        }
    }
}
