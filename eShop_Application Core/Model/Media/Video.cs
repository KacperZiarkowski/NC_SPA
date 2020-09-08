using eShop_ApplicationCore.Model.Interfaces;

namespace eShop_ApplicationCore.Model.Media
{
    public class Video : IMedia
    {
        public string FileName { get; }

        public string MediaUrl { get; }
    }
}
