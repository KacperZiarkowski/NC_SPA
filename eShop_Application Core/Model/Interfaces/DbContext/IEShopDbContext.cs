using System.Threading.Tasks;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using eShop_ApplicationCore.Model;
using eShop_ApplicationCore.Model.Interfaces.DbContext;


namespace eShop_ApplicationCore.Model.Interfaces.DbContext
{
    public interface IEShopDbContext : IProductDbContext, IOrderDbContext, ITaxDbContext, IBasketDbContext
    {
        Task<T> GetByIdAsync<T>(int id) where T : Entity;

    }
}
