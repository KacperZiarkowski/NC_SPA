namespace eShop_ApplicationCore.Model.Interfaces.DbContext
{
  using System;
  using System.Data.Entity;
  using System.Linq;
  using System.Linq.Expressions;


  public interface IeShopDbContext : IProductDbContext, IOrderDbContext, ITaxDbContext
  {

  }
}
