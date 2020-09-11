using eShop_ApplicationCore.Model;

namespace eShop_ApplicationCore.Interfaces.DbContext
{
    public interface IEShopDbContext : IProductDbContext, IOrderDbContext, ITaxDbContext, IBasketDbContext, IEShopDbContextBaseAsyncOperations<Entity>
    {

    }
}
