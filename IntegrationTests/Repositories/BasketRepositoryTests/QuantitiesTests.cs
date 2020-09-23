using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eShop_ApplicationCore.Interfaces.DbContext;
using eShop_ApplicationCore.Model.Basket;
using eShop_ApplicationCore.Services;
using eShop_Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using UnitTests.Helpers.BasketBuilder;

namespace IntegrationTests.Repositories.BasketRepositoryTests
{
    class QuantitiesTests
    {
        private readonly EShopDbContext _eShopDbContext;
        private readonly BuildBasket _buildBasket = new BuildBasket();

        public QuantitiesTests()
        {
            var dbOptions = new DbContextOptionsBuilder<EShopDbContext>()
                .UseInMemoryDatabase(databaseName: "eShopTest")
                .Options;
            _eShopDbContext = new EShopDbContext(dbOptions);
        }

        [Test]
        public async Task SetQuantities()
        {
            var basket = _buildBasket.EmptyBasket();
            var basketService = new BasketService(_eShopDbContext, null);
            await _eShopDbContext.Baskets.AddAsync(basket);
           
            basket.AddProduct(1, 1.99m);
            await _eShopDbContext.SaveChangesAsync();

            await basketService.SetQuantity(basket.Id, 1, 0);

            Assert.AreEqual(0, basket.Items.Count);
        }
    }
}
