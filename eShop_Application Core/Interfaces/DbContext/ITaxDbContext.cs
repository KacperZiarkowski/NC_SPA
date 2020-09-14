using eShop_ApplicationCore.Model.Tax;
using Microsoft.EntityFrameworkCore;

namespace eShop_ApplicationCore.Interfaces.DbContext
{
    public interface ITaxDbContext : IEShopDbContextBaseAsyncOperations
    {
        DbSet<Vat> Taxes { get; set; }

        DbSet<VatRule> VatRules { get; set; }
    }
}
