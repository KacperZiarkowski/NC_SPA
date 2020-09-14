using Microsoft.EntityFrameworkCore;
using eShop_ApplicationCore.Model.Product;

namespace eShop_ApplicationCore.Interfaces.DbContext
{
    public interface IProductDbContext : IEShopDbContextBaseAsyncOperations
    {
        public DbSet<Model.Product.Product> Products { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
