using eShop_ApplicationCore.Model.Product;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop_ApplicationCore.Model.Basket
{
    public class BasketItem
    {
        public decimal BasePrice { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("BasketItemId")]
        public int BasketItemId { get; set; }

        [ForeignKey(nameof(Basket))]
        public int BasketId { get; set; }

        public Basket Basket { get; set; }


    }
}

