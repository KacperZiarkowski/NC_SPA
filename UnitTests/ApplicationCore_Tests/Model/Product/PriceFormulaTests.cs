using System;
using System.Collections.Generic;
using System.Text;
using eShop_ApplicationCore.Model.Product;
using eShop_ApplicationCore.Model.Tax;
using NUnit.Framework;

namespace UnitTests.ApplicationCore_Tests.Model.Product
{
    [TestFixture]
    class PriceFormulaTests
    {
        private readonly eShop_ApplicationCore.Model.Product.Product _product =
            new eShop_ApplicationCore.Model.Product.Product { ProductBasePrice = 12.89m };
       
        private readonly Catalog _catalog = new Catalog { PriceModifier = 0.22m };
        
        private readonly Vat _tax = new Vat { VatRate = 0.22m };
        

        [Test]

    }
}
