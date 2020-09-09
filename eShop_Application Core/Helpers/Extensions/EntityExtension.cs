using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eShop_ApplicationCore.Model;

namespace eShop_ApplicationCore.Helpers.Extensions
{
    public static class EntityExtension
    {
        Task<T> GetByIdAsync<T>(int id) where T : Entity
        {
            
        }
    }
}
