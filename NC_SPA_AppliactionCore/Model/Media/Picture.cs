
using System;
using System.Collections.Generic;
using System.Text;
using eShop_ApplicationCore.Model.Interface;

namespace eShop_ApplicationCore.Model.Media
{
    public class Picture : Entity, IMedia
    {
        public string FileName { get; set; }
        public string MediaUrl { get; set; }
    }
}
