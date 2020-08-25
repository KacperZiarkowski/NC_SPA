using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework.Internal;
using eShop_ApplicationCore.Model.Basket;
using System.Linq;

namespace UnitTests.ApplicationCore_Tests.Model.Basket
{
    [TestFixture]
    class BasketTests
    {
        private const string BuyerId = "1234D";

        private eShop_ApplicationCore.Model.Basket.Basket _testBasket =
            new eShop_ApplicationCore.Model.Basket.Basket(BuyerId);

        [Test]
        public void Basket_Should_CreateNewBasket_When_BuyerIsGiven()
        {
            var basket = new eShop_ApplicationCore.Model.Basket.Basket(BuyerId);

            Assert.IsNotNull(basket);
        }

        [Test]
        [TestCase(1, 3.66, 1)]
        public void Basket_AddItem_Should_AddDistinctSingleItem_When_ItemIsGivenAndQuantityIsNotGiven(
            int productId,
            decimal price,
            int result)
        {
            var basket = new eShop_ApplicationCore.Model.Basket.Basket(BuyerId);

            basket.AddItem(productId, price);

            Assert.AreEqual(result, basket.Items.Count);
        }

        [Test]
        [TestCase(1, 3.66, 1)]
        public void Basket_AddItem_Should_AddMultipleItemsAndIncrementQuantity_When_ItemIsGivenAndAlreadyExistsInBasket(
            int productId,
            decimal price,
            int baseQuantity)
        {
            _testBasket.AddItem(productId, price);
            _testBasket.AddItem(1, 23);

            var resultItem = _testBasket.Items.First(i => i.ProductId == productId);

            Assert.AreEqual(baseQuantity * 2, resultItem.Quantity);
        }

        [Test]
        [TestCase(1, 1.56, 4)]
        public void Basket_TotalCost_Should_ReturnCorrectValue_When_ItemsAreAddedToTheBasket(
            int productId,
            decimal price,
            int quantity)
        {
            _testBasket.AddItem(productId, price, quantity);
            _testBasket.AddItem(productId, price, quantity);
            _testBasket.AddItem(2, 2, 5);

            var totalPriceFormula = ((price * quantity) * 2) + 2 * 5;

            Assert.AreEqual(totalPriceFormula, _testBasket.TotalCost);
        }

        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(1, 1, 9999)]
        [TestCase(1, 1, 99999999)]
        [TestCase(1, 0, 0)]
        [TestCase(1, 0.000000009, 0)]
        public void Basket_RemoveAllBasketItems_Should_RemoveAllBasketItems(int productId, decimal price, int quantity)
        {
            _testBasket.AddItem(productId, price, quantity);
            _testBasket.AddItem(productId, price, quantity);
            _testBasket.AddItem(productId, price, quantity);
            _testBasket.AddItem(productId, price, quantity);

            _testBasket.RemoveAllItems();
            Assert.AreEqual(0, _testBasket.Items.Count);
        }

    }
}
