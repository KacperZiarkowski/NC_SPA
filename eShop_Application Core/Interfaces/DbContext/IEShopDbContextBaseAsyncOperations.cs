using eShop_ApplicationCore.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop_ApplicationCore.Interfaces.DbContext
{
    public interface IEShopDbContextBaseAsyncOperations
    {
        Task UpdateAsync(Entity entity);

        Task DeleteAsync(Entity entity);

        Task<Entity> AddAsync(Entity entity);
    }
}
