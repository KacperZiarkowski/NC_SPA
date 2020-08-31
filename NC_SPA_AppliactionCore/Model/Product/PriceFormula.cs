using System;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Model.Product
{
    public static class PriceFormula
    {
        public static decimal CalculateProductTotalCost(decimal price, decimal vatRate, decimal priceModifier)
        {
            return Math.Round(price * (1m + vatRate) * (1m + priceModifier),3);
        }
    }
}
