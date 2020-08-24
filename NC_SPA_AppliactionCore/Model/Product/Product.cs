using eShop_ApplicationCore.Model.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Model.Product
{
    public class Product : Entity
    {
        public decimal ProductBasePrice { get; private set; }
        public string ProductName { get; private set; }
        public Catalog Catalog { get; private set; }
        public Category ProductCategory { get; private set; }
        public string ProductDescription { get; private set; }

        public virtual ICollection<IMedia> Media { get; private set; }

    }
}
