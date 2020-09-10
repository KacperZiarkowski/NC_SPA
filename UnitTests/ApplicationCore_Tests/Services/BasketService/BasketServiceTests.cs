using System;
using System.Collections.Generic;
using System.Text;
using eShop_ApplicationCore.Interfaces.DbContext;
using eShop_ApplicationCore.Model.Basket;
using NUnit.Framework;

namespace UnitTests.ApplicationCore_Tests.Services.BasketService
{
    [TestFixture]
    class BasketServiceTests
    {
        private readonly IEShopDbContext eShopDbContext;

        [Test]
        public void BasketService_AddProductToBasket_Should_AddItemToExistingBasket()
        {
            eShopDbContext.GetByIdAsync<Basket>(0);
        }

    }
}
