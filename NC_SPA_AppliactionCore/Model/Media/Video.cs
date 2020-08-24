using eShop_ApplicationCore.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Model.Media
{
    public class Video : IMedia
    {
        public string FileName { get; }
        public string MediaUrl { get; }
    }
}
