using eShop_ApplicationCore.Model.Media;

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
