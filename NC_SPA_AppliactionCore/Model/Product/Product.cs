using eShop_ApplicationCore.Model.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using eShop_ApplicationCore.Model.Media;

namespace eShop_ApplicationCore.Model.Product
{
    public class Product : Entity, IProduct
    {
        public decimal ProductBasePrice { get; set; }

        public string Name { get; set; }

        public Catalog Catalog { get; set; }

        public int CatalogId { get; set; }

        public Category ProductCategory { get; set; }

        public int CategoryId { get; set; }

        public string Description { get; set; }

        public Picture Picture { get; set; }

        public int PictureId { get; set; }

        public string VideoUrl { get; set; }


    }
}
