namespace eShop_ApplicationCore.Model.Interfaces
{
    public interface IPriceCalculation
    {
        public decimal CalculateProductTotalCost(decimal productBasePrice, decimal vatRate, decimal catalogPriceModifier);
    }
}
