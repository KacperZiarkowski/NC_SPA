using System;
using System.Collections.Generic;
using System.Text;
using eShop_ApplicationCore.Model.Abstract;

namespace eShop_ApplicationCore.Model.Product
{
    public class Catalog : IProduct
    {
        public string Name { get; }
        public string Description { get; }
    }
}
