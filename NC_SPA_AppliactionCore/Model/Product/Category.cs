using eShop_ApplicationCore.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Model.Product
{
    public class Category : Entity, IProduct
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
    }
}
