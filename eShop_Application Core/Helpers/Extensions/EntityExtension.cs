using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using eShop_ApplicationCore.Model;

namespace eShop_ApplicationCore.Helpers.Extensions
{
    public static class EntityExtension
    {
        protected readonly EShopDbContext _eShopDbContext;


        Task<T> GetByIdAsync<T>(int id) where T : DbSet
        {
           
        }
    }
}
