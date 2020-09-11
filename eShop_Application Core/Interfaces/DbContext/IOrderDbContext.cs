using System.Data.Entity;
using eShop_ApplicationCore.Model.Order;

namespace eShop_ApplicationCore.Interfaces.DbContext
{
    public interface IOrderDbContext : IEShopDbContextBaseAsyncOperations
    {
        DbSet<Model.Order.Order> Orders { get; set; }

        DbSet<OrderItem> OrderItems{ get; set; }
    }
}
