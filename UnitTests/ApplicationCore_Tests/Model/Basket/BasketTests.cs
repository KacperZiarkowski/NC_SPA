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
        private static readonly Guid BuyerId = Guid.NewGuid();

        private eShop_ApplicationCore.Model.Basket.Basket _testBasket =
            new eShop_ApplicationCore.Model.Basket.Basket { BuyerGuid = BuyerId };

        [SetUp]
        public void SetupBeforeEachTest()
        {
            _testBasket.RemoveAllProducts();
        }

        [Test]
        public void Basket_Should_CreateNewBasket_When_BuyerIsGiven()
        {
            var basket = new eShop_ApplicationCore.Model.Basket.Basket { BuyerGuid = BuyerId };

            Assert.IsNotNull(basket);
        }

        [Test]
        [TestCase(1, 3.66, 1)]
        public void Basket_AddItem_Should_AddDistinctSingleItem_When_ItemIsGivenAndQuantityIsNotGiven(
            int productId,
            decimal price,
            int result)
        {
            var basket = new eShop_ApplicationCore.Model.Basket.Basket { BuyerGuid = BuyerId };

            basket.AddProduct(productId, price);

            Assert.AreEqual(result, basket.Items.Count);
        }

        [Test]
        [TestCase(1, 3.66, 1)]
        public void Basket_AddItem_Should_AddMultipleItemsAndIncrementQuantity_When_ItemIsGivenAndAlreadyExistsInBasket(
            int productId,
            decimal price,
            int baseQuantity)
        {
            _testBasket.AddProduct(productId, price);
            _testBasket.AddProduct(1, 23);

            var resultItem = _testBasket.Items.First(i => i.ProductId == productId);

            Assert.AreEqual(baseQuantity * 2, resultItem.Quantity);
        }

        [Test]
        [TestCase(1, 1.56m, 0,0,4)]
        public void Basket_TotalCostWithoutVAT_Should_ReturnCorrectValue_When_ItemsAreAddedToTheBasket(
            int productId,
            decimal price,
            decimal vatRate,
            decimal priceModifier,
            int quantity)
        {
            _testBasket.AddProduct(productId, price,vatRate, priceModifier, quantity);

            var totalPriceFormula = (price * (1m + vatRate) * (1 + priceModifier)) * quantity;

            Assert.AreEqual(totalPriceFormula, _testBasket.TotalCost());
        }

        [Test]
        [TestCase(1, 1, 1)]
        [TestCase(1, 1, 9999)]
        [TestCase(1, 1, 99999999)]
        [TestCase(1, 0, 0)]
        [TestCase(1, 0.000000009, 0)]
        public void Basket_RemoveAllBasketItems_Should_RemoveAllBasketItems_When_MethodIsExecuted(int productId, decimal price, int quantity)
        {
            _testBasket.AddProduct(productId, price, quantity);
            _testBasket.AddProduct(productId, price, quantity);
            _testBasket.AddProduct(productId, price, quantity);
            _testBasket.AddProduct(productId, price, quantity);

            _testBasket.RemoveAllProducts();

            Assert.AreEqual(0, _testBasket.Items.Count);
        }

        [Test]
        [TestCase(1, 1, 1)]
        public void Basket_RemoveSingleItem_Should_RemoveSingleProduct_When_ItemQuantityIsLessThanTwo(int productId, decimal price, int quantity)
        {
            _testBasket.AddProduct(productId, price, quantity);

            _testBasket.RemoveSingleProduct(productId);

            Assert.AreEqual(false, _testBasket.Items.Any());
        }
        [Test]
        [TestCase(1, 1, 1)]
        public void Basket_RemoveSingleItem_Should_DecreaseProductQuantity_When_ItemQuantityIsMoreThanOne(int productId, decimal price, int quantity)
        {
            _testBasket.AddProduct(productId, price, quantity);
            _testBasket.AddProduct(productId, price, quantity);

            var basketWithSingleProductWithQuantityEqualsOne =
                new eShop_ApplicationCore.Model.Basket.Basket { BuyerGuid = BuyerId };
            basketWithSingleProductWithQuantityEqualsOne.AddProduct(1, 1, 1);

            var testProductQuantity = basketWithSingleProductWithQuantityEqualsOne.Items.First().Quantity;

            _testBasket.RemoveSingleProduct(productId);

            Assert.AreEqual(testProductQuantity, _testBasket.Items.First().Quantity);
        }

    }
}
