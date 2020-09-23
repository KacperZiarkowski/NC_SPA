using eShop_ApplicationCore.Model.Product;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop_ApplicationCore.Model.Basket
{
    public class BasketItem : Entity
    {
        public BasketItem()
        {
            
        }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }

        public Product.Product Product { get; set; }

        [ForeignKey(nameof(Basket))]
        public int BasketId { get; set; }

        public Basket Basket { get; set; }


    }
}

