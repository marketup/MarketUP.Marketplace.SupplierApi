﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class ShippingType
    {
        [JsonProperty("ShippingTypeID")]
        public string ShippingTypeID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public ShippingType()
        {

        }

        public ShippingType(string shippingTypeID, string name)
        {
            this.ShippingTypeID = shippingTypeID;
            this.Name = name;
        }
    }
}
