using System.ComponentModel.DataAnnotations.Schema;

namespace eShop_ApplicationCore.Model.Order
{
    public class OrderItem : Entity
    {
        public OrderItem(int productId, int quantity, decimal price)
        {
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }
        

        public int Quantity { get; private set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; private set; }

        public decimal Price { get; private set; }

    }
}
