using eShop_ApplicationCore.Model.Tax;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace eShop_ApplicationCore.Model.Interfaces.DbContext
{
    public interface ITaxDbContext
    {
        DbSet<Vat> Taxes { get; set; }

        DbSet<VatRule> VatRules { get; set; }
    }
}
