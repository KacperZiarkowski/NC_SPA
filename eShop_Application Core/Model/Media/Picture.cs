using eShop_ApplicationCore.Model.Interfaces;

namespace eShop_ApplicationCore.Model.Media
{
    public class Picture : Entity, IMedia
    {
        public string FileName { get; set; }

        public string MediaUrl { get; set; }
    }
}
