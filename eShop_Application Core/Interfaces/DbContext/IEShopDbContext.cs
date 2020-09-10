namespace eShop_ApplicationCore.Interfaces.DbContext
{
    public interface IEShopDbContext : IProductDbContext, IOrderDbContext, ITaxDbContext, IBasketDbContext
    {

    }
}
