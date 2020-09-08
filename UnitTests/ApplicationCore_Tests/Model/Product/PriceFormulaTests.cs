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
        
        private readonly Vat _vat = new Vat { VatRate = 0.22m };


        private static decimal PriceFormula(decimal basePrice, decimal vatRate, decimal priceModifier)
        {
            return Math.Round(Math.Round(basePrice * (1m + vatRate),2) * (1m + priceModifier), 2);
        }

        [Test]
        [TestCase(12.89, 0.22,0.22)]
        public void PriceFormula_CalculateProductTotalCost_Should_Return_CorrectValue_When_DecimalAndMoneyPricePartsAreGiven(decimal basePrice, decimal vatRate, decimal priceModifier)
        {
            var priceFormulaCalculation = new PriceFormula();

            var calculatedCost = priceFormulaCalculation.CalculateProductTotalCost(_product.ProductBasePrice,_vat.VatRate,_catalog.PriceModifier);

            var expectedCost = PriceFormula(basePrice, vatRate, priceModifier);

            Assert.AreEqual(expectedCost, calculatedCost);
        }


        [Test]
        [TestCase(12.89, 0.22, 0.22)]
        [TestCase(12.89, 0.22, -0.22)]
        [TestCase(0.99, 0.22, -0.22)]
        [TestCase(0.99, 0.22, 0.22)]
        public void PriceFormula_CalculateProductTotalCost_Should_Return_CorrectValue_When_DecimalPricePartsAreGiven(decimal basePrice, decimal vatRate, decimal priceModifier)
        {
            var priceFormulaCalculation = new PriceFormula();

            var calculatedCost = priceFormulaCalculation.CalculateProductTotalCost(basePrice,vatRate,priceModifier);

            var expectedCost = PriceFormula(basePrice, vatRate, priceModifier);

            Assert.AreEqual(expectedCost, calculatedCost);
        }
    }
}
