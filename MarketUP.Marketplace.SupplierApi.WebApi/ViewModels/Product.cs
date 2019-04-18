using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketUP.Marketplace.Integration.ModelsSupplierApi
{
    public class Product
    {
        [JsonProperty("productID")]
        public string ProductID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("ncm")]
        public string Ncm { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("itemGroup")]
        public string ItemGroup { get; set; }

        [JsonProperty("itemCategory")]
        public string ItemCategory { get; set; }

        [JsonProperty("itemSubcategory")]
        public string ItemSubcategory { get; set; }

        [JsonProperty("images")]
        public List<ProductImage> Images { get; set; }

        [JsonProperty("itemsInPackage")]
        public int ItemsInPackage { get; set; }
        
        [JsonProperty("minimumSaleQuantity")]
        public int MinimumSaleQuantity { get; set; }

        [JsonProperty("multipleQuantity")]
        public int MultipleQuantity { get; set; }

        [JsonProperty("sellerCode")]
        public string SellerCode { get; set; }

        [JsonProperty("value")]
        public decimal Value { get; set; }
        
        [JsonProperty("stockQuantity")]
        public decimal? StockQuantity { get; set; }


        [JsonProperty("hasBox")]
        public bool HasBox { get; set; }

        [JsonProperty("packagesInBox")]
        public int PackagesInBox { get; set; }

        [JsonProperty("boxValue")]
        public decimal BoxValue { get; set; }

        [JsonProperty("boxStockQuantity")]
        public decimal? BoxStockQuantity { get; set; }


        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("restrictions")]
        public List<ProductRestriction> Restrictions { get; set; }

        public Product()
        {

        }

        public Product(string productID, string name, string description, string barcode, string ncm, string brand,
            string itemGroup, string itemCategory, string itemSubcategory,
            List<ProductImage> images, 
            int itensInPackage, int minimumSaleQuantity, int multipleQuantity, 
            string sellerCode,
            decimal value, int? stockQuantity,
            bool hasBox, int packagesInBox, decimal boxValue, int? boxStockQuantity,
            bool isActive,
            List<ProductRestriction> restrictions)
        {
            this.ProductID = productID;
            this.Name = name;
            this.Description = description;
            this.Barcode = barcode;
            this.Ncm = ncm;
            this.Brand = brand;
            this.ItemGroup = itemGroup;
            this.ItemCategory = itemCategory;
            this.ItemSubcategory = itemSubcategory;
            this.Images = images;
            this.ItemsInPackage = itensInPackage;
            this.MinimumSaleQuantity = minimumSaleQuantity;
            this.MultipleQuantity = multipleQuantity;
            this.SellerCode = sellerCode;

            this.Value = value;
            this.StockQuantity = stockQuantity;

            this.HasBox = hasBox;
            this.PackagesInBox = packagesInBox;
            this.BoxValue = boxValue;
            this.BoxStockQuantity = boxStockQuantity;

            this.IsActive = isActive;
            this.Restrictions = restrictions;
        }
    }
}
