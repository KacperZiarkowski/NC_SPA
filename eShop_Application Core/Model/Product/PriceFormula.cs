using System;
using System.Collections.Generic;
using System.Text;
using eShop_ApplicationCore.Model.Interfaces;
using eShop_ApplicationCore.Model.Tax;

namespace eShop_ApplicationCore.Model.Product
{
    public class PriceFormula : IPriceCalculation
    {

        public decimal CalculateProductTotalCost(decimal productBasePrice, decimal vatRate, decimal catalogPriceModifier)
        {
            return Math.Round(Math.Round(productBasePrice * (1m + vatRate),2) * (1m + catalogPriceModifier), 2);
        }
    }
}
