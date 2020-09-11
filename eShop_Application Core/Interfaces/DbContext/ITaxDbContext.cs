using System.Data.Entity;
using eShop_ApplicationCore.Model.Tax;

namespace eShop_ApplicationCore.Interfaces.DbContext
{
    public interface ITaxDbContext : IEShopDbContextBaseAsyncOperations
    {
        DbSet<Vat> Taxes { get; set; }

        DbSet<VatRule> VatRules { get; set; }
    }
}
