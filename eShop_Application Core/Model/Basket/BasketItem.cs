using System.ComponentModel.DataAnnotations.Schema;

namespace eShop_ApplicationCore.Model.Basket
{
    public class BasketItem
    {
        public decimal Price { get; set; }


        public int Quantity { get; set; }


        [ForeignKey("ProductId")]
        public int ProductId { get; set; }


        [ForeignKey("BasketId")]
        public int BasketId { get; set; }

    }
}

