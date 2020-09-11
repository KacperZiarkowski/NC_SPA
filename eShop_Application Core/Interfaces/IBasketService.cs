using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop_ApplicationCore.Interfaces
{
    public interface IBasketService
    {
        Task AddProductToBasket(int basketId, int productId, decimal productPrice, int quantity = 1);

        Task SetQuantity(int basketId, int productId, int quantity);

        Task ClearBasket(int basketId);
    }
}
