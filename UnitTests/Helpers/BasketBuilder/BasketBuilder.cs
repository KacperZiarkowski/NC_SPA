using eShop_ApplicationCore.Model.Basket;
using System;
using Force.DeepCloner;
using System.Diagnostics;

namespace UnitTests.Helpers.BasketBuilder
{
    /// <summary>
    /// Helper class for creating basket for test usage
    /// </summary>
    public class BasketBuilder
    {
        private Basket _basket;

        private readonly Guid _buyerGuid = Guid.NewGuid();

        private const int _basketId = 1;


        public BasketBuilder()
        {
            _basket = new Basket()
            {
                BuyerGuid = _buyerGuid,
                Id = _basketId
            };
        }


        public BasketBuilder BasketWithOneProduct(decimal price)
        {
            _basket.AddItem(1, price);
            return this;
        }


        public Basket Build()
        {           
            return _basket.ShallowClone();
        }

    }
}
