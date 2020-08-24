using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using eShop_ApplicationCore.Model.Product;

namespace eShop_ApplicationCore.Model.Order
{
    public class OrderItem : Entity
    {
        public virtual Product.Product OrderedProduct { get; private set; }

        public int Quantity { get; private set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; private set; }

    }
}
