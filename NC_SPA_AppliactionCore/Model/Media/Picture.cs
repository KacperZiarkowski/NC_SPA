
using System;
using System.Collections.Generic;
using System.Text;
using eShop_ApplicationCore.Model.Interface;

namespace eShop_ApplicationCore.Model.Media
{
    public class Picture : IMedia
    {
        public string FileName { get; }
        public string MediaUrl { get; }
    }
}
