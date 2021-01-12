using eShop_ApplicationCore.Model.Basket;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Helpers.BasketBuilder
{
    /// <summary>
    /// Helper class for creating basket for test usage
    /// </summary>
    public class BuildBasket
    {
        private Basket _basket;

        private readonly Guid _buyerGuid = Guid.NewGuid();

        private const int _basketId = 1;


        public BuildBasket()
        {
            _basket = EmptyBasket();
        }


        public Basket EmptyBasket()
        {
            _basket = new Basket { BuyerGuid = _buyerGuid, Id = _basketId };
            return _basket;
        }


        public Basket BasketWithOneProduct()
        {
            _basket = new Basket { BuyerGuid = _buyerGuid, Id = _basketId };
            _basket.AddProduct(1, 12.99m);
            return _basket;
        }

    }
}
