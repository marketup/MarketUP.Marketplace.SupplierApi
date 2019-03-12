﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class OrderSendRequest
    {
        [JsonProperty("clientID")]
        public string ClientID { get; set; }

        [JsonProperty("billingAddress")]
        public Address BillingAddress { get; set; }

        [JsonProperty("deliveryAddress")]
        public DeliveryAddress DeliveryAddress { get; set; }

        [JsonProperty("products")]
        public List<ShoppingProductRequest> Products { get; set; }

        [JsonProperty("paymentInformation")]
        public PaymentInformation PaymentInformation { get; set; }

        [JsonProperty("shippingInformation")]
        public ShippingInformation ShippingInformation { get; set; }

        [JsonProperty("client")]
        public Client Client { get; set; }

        public OrderSendRequest()
        {

        }

        public OrderSendRequest(string clientID, Address billingAddress, DeliveryAddress deliveryAddress, List<ShoppingProductRequest> products, PaymentInformation paymentInformation, ShippingInformation shippingInformation,Client client)
        {
            this.ClientID = clientID;
            this.BillingAddress = billingAddress;
            this.DeliveryAddress = deliveryAddress;
            this.Products = products;
            this.PaymentInformation = paymentInformation;
            this.ShippingInformation = shippingInformation;
            this.Client = client;
        }
    }
}