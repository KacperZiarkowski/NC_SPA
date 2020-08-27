using System;
using System.Collections.Generic;
using System.Text;
using eShop_ApplicationCore.Model.Interface;
using eShop_ApplicationCore.Model.Media;

namespace eShop_ApplicationCore.Model.Product
{
    public class Catalog : Entity, IProduct
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Picture Picture { get; set; }

        public int PictureId { get; set; }

        public DateTime? EffectiveFrom { get; set; }

        public DateTime? EffectiveTo { get; set; }

        public decimal PriceIncrease { get; set; }


    }
}
