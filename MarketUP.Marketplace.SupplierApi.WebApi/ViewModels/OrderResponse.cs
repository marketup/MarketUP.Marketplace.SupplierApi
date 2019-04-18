using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class OrderResponse : BaseResponse
    {
        [JsonProperty("orderID")]
        public string OrderID { get; set; }

        [JsonProperty("clientID")]
        public string ClientID { get; set; }

        [JsonProperty("billingAddress")]
        public Address BillingAddress { get; set; }

        [JsonProperty("deliveryAddress")]
        public DeliveryAddress DeliveryAddress { get; set; }

        [JsonProperty("products")]
        public List<OrderProduct> Products { get; set; }

        [JsonProperty("paymentInformation")]
        public PaymentInformation PaymentInformation { get; set; }

        [JsonProperty("bankSlipUrl")]
        public string BankSlipUrl { get; set; }

        [JsonProperty("shippingInformation")]
        public ShippingInformation ShippingInformation { get; set; }

        [JsonProperty("invoiceInformation")]
        public InvoiceInformation InvoiceInformation { get; set; }

        [JsonProperty("orderStatus")]
        public string OrderStatus { get; set; }

        [JsonProperty("orderStatusMessage")]
        public string OrderStatusMessage { get; set; }

        [JsonProperty("orderShippings")]
        public List<OrderShipping> OrderShippings { get; set; }

        [JsonProperty("orderStatusHistory")]
        public List<OrderStatusHistory> OrderStatusHistory { get; set; }

        [JsonProperty("client")]
        public Client Client { get; set; }

        public OrderResponse()
        {

        }

        public OrderResponse(string orderID, string clientID, Address billingAddress, DeliveryAddress deliveryAddress, List<OrderProduct> products,
            PaymentInformation paymentInformation, string bankSlipUrl, ShippingInformation shippingInformation,
            string orderStatus, string orderStatusMessage, List<OrderShipping> orderShippings, List<OrderStatusHistory> orderStatusHistory,
            Client client, InvoiceInformation invoiceInformation)
        {
            this.OrderID = orderID;
            this.ClientID = clientID;
            this.BillingAddress = billingAddress;
            this.DeliveryAddress = deliveryAddress;
            this.Products = products;
            this.PaymentInformation = paymentInformation;
            this.BankSlipUrl = bankSlipUrl;
            this.ShippingInformation = shippingInformation;
            this.OrderStatus = orderStatus;
            this.OrderStatusMessage = orderStatusMessage;
            this.OrderShippings = orderShippings;
            this.OrderStatusHistory = orderStatusHistory;
            this.Client = client;
            this.InvoiceInformation = invoiceInformation;
        }
    }
}
