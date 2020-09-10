using eShop_ApplicationCore.Interfaces;
using eShop_ApplicationCore.Model.Media;

namespace eShop_ApplicationCore.Model.Product
{
    public class Category : Entity, IProduct
    {
        public string Name { get;  set; }

        public string Description { get;  set; }

        public Picture Picture { get; set; }

        public int PictureId { get; set; }
    }
}
