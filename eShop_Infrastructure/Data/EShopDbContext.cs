using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eShop_ApplicationCore.Interfaces.DbContext;
using eShop_ApplicationCore.Model;
using eShop_ApplicationCore.Model.Basket;
using eShop_ApplicationCore.Model.Order;
using eShop_ApplicationCore.Model.Product;
using eShop_ApplicationCore.Model.Tax;
using Microsoft.EntityFrameworkCore;

namespace eShop_Infrastructure.Data
{
    /// <summary>
    /// Application DbContext
    /// </summary>
    class EShopDbContext : DbContext, IEShopDbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options) 
            : base(options)
        {
      
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Vat> Taxes { get; set; }
        public DbSet<VatRule> VatRules { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        
        
        public async Task UpdateAsync(Entity entity)
        {
            this.Entry(entity).State = EntityState.Modified;
            await this.SaveChangesAsync();
        }

        public Task DeleteAsync(Entity entity)
        {
            throw new NotImplementedException();
        }

        public Task<Entity> AddAsync(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
