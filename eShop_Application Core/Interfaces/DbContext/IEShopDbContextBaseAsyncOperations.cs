using eShop_ApplicationCore.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop_ApplicationCore.Interfaces.DbContext
{
    public interface IEShopDbContextBaseAsyncOperations<T> where T : Entity
    {
        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<T> AddAsync(T entity);
    }
}
