using System;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Model.Product
{
    public class Product : Entity
    {
        public decimal ProductPrice { get; private set; }
        public string ProductName { get; private set; }
    }
}
