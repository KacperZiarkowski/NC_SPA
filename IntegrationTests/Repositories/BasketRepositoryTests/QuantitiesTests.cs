using System;
using System.Collections.Generic;
using System.Text;
using eShop_ApplicationCore.Interfaces.DbContext;
using eShop_Infrastructure.Data;
using UnitTests.Helpers.BasketBuilder;

namespace IntegrationTests.Repositories.BasketRepositoryTests
{
    class QuantitiesTests
    {
        private readonly EShopDbContext _eShopDbContext;
        private readonly IBasketDbContext _basketDbContext;

        public QuantitiesTests()
        {

            var testBasket = new BasketBuilder()
                .BasketWithOneProduct(12.9m)
                .Build();
        }

    }
}
