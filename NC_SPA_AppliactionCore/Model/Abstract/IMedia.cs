using System;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Model.Abstract
{
    public interface IMedia
    {
        public string FileName { get; }
        public string MediaUrl { get; }
    }
}
