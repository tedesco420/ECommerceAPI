﻿using ECommerceAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public ICollection<Order> Orders { get; set; }

        public ICollection<ProductImageFile> ProductImageFiles { get; set; }
    }
}
