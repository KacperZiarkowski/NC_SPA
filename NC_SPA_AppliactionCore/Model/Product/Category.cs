﻿using eShop_ApplicationCore.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
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
