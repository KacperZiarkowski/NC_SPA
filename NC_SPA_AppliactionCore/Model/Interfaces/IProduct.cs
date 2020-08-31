using eShop_ApplicationCore.Model.Media;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Model.Interfaces
{
    public interface IProduct
    {
        string Name { get; }
        string Description { get; }
        Picture Picture { get; set; }
        int PictureId { get; set; }
    }
}
