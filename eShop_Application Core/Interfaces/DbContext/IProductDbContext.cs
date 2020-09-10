using eShop_ApplicationCore.Model.Product;
using System.Data.Entity;

namespace eShop_ApplicationCore.Model.Interfaces.DbContext
{
    public interface IProductDbContext
    {
        public DbSet<Product.Product> Products { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
