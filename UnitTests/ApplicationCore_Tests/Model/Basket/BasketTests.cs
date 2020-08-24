using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace UnitTests.ApplicationCore_Tests.Model.Basket
{
    [TestFixture]
    class BasketTests
    {
        [Test]
        public void CreteNewEmptyBasket_IsNotNul()
        {
            var basket = new eShop_ApplicationCore.Model.Basket.Basket("1234D");
            Assert.IsNotNull(basket);
        }


    }
}
