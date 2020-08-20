using System;
using System.Collections.Generic;
using System.Text;
using eShop_ApplicationCore.Model.ProductsCatalog;

namespace eShop_ApplicationCore.Model.Product
{
    public class Product : Entity
    {
        public decimal ProductBasePrice { get; private set; }
        public string ProductName { get; private set; }
        public Catalog CatalogId { get; private set; }
        public Category CatalogId { get; private set; }
    }
}
