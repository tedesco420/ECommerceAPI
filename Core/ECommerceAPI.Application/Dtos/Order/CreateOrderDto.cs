﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Dtos.Order
{
    public class CreateOrderDto
    {
        public int BasketId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; } //DDD
    }
}
