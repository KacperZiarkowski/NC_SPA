namespace eShop_ApplicationCore.Interfaces
{
    public interface IPriceCalculation
    {
        public decimal CalculateProductTotalCost(decimal productBasePrice, decimal vatRate, decimal catalogPriceModifier);
    }
}
