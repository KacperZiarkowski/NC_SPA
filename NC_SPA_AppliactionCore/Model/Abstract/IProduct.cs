using System;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Model.Abstract
{
    public interface IProduct
    {
        string Name { get; }
        string Description { get; }
    }
}
