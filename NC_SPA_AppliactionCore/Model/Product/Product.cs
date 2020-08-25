using eShop_ApplicationCore.Model.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Model.Product
{
    public class Product : Entity, IProduct
    {
        public decimal ProductBasePrice { get; private set; }
        public string Name { get; private set; }
        public Catalog Catalog { get; private set; }
        public int CatalogId { get; private set; }
        public Category ProductCategory { get; private set; }
        public int CategoryId { get; private set; }
        public string Description { get; private set; }
        public string ImageUrl { get; private set; }

    }
}
