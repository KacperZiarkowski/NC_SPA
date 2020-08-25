using System;
using System.Collections.Generic;
using System.Text;
using eShop_ApplicationCore.Model.Abstract;

namespace eShop_ApplicationCore.Model.Product
{
    public class Catalog : Entity, IProduct
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
    }
}
