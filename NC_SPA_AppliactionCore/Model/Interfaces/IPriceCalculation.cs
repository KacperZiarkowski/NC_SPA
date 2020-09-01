using System;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Model.Interfaces
{
    public interface IPriceCalculation
    {
        public decimal CalculateProductTotalCost();
    }
}
