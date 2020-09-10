using eShop_ApplicationCore.Model.Order;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace eShop_ApplicationCore.Model.Interfaces.DbContext
{
    public interface IOrderDbContext
    {
        DbSet<Order.Order> Orders { get; set; }

        DbSet<OrderItem> OrderItems{ get; set; }
    }
}
