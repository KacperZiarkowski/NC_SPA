using System;
using System.Collections.Generic;
using System.Text;
using eShop_ApplicationCore.Model.Interfaces;
using eShop_ApplicationCore.Model.Tax;

namespace eShop_ApplicationCore.Model.Product
{
    public class PriceFormula : IPriceCalculation
    {
        private readonly Product _product;
        private readonly Catalog _catalog;
        private readonly Vat _tax;

        public PriceFormula(Product product,Catalog catalog, Vat vat)
        {
            _product = product;
            _catalog = catalog;
            _tax = vat;
        }

        public decimal CalculateProductTotalCost()
        {
            return Math.Round(_product.ProductBasePrice * (1m + _tax.VatRate) * (1m + _catalog.PriceModifier),3);
        }
    }
}
