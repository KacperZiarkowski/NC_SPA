using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using eShop_ApplicationCore.Interfaces.DbContext;
using eShop_ApplicationCore.Model;
using eShop_ApplicationCore.Model.Basket;
using eShop_ApplicationCore.Model.Order;
using eShop_ApplicationCore.Model.Product;
using eShop_ApplicationCore.Model.Tax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace eShop_Infrastructure.Data
{
    /// <summary>
    /// Application DbContext
    /// </summary>
    public class EShopDbContext : DbContext, IEShopDbContext
    {

        public EShopDbContext()
        {

        }

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

        public string UserName { get; set; }


        public async Task UpdateAsync(Entity entity)
        {
            Entry(entity).State = EntityState.Modified;
            await SaveChangesAsync();
        }

        public async Task DeleteAsync(Entity entity)
        {
            Set<Entity>().Remove(entity);
            await SaveChangesAsync();
        }

        public async Task<Entity> AddAsync(Entity entity)
        {
            await Set<Entity>().AddAsync(entity);
            await SaveChangesAsync();

            return entity;
        }
        
        public override int SaveChanges()
        {
            IEnumerable<EntityEntry> entities = null;
            if (ChangeTracker?.Entries() != null)
            {
                entities = ChangeTracker.Entries().Where(x => x.Entity is Entity && (x.State == EntityState.Added || x.State == EntityState.Modified));
            }

            var currentUsername = UserName ?? "Annonymous";

            if (entities == null) return base.SaveChanges();

            foreach (var entity in entities)
            {
                var ent = (Entity)entity.Entity;
                if (ent == null) continue;

                if (entity.State == EntityState.Added)
                {
                    ent.CreatedDate = DateTime.Now;
                    ent.ModifiedBy = currentUsername;
                }

                ent.ModifiedDate = DateTime.Now;
                ent.ModifiedBy = currentUsername;
            }

            return base.SaveChanges();
        }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }

}
