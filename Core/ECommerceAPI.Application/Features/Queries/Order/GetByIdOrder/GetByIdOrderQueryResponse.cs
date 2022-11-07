﻿namespace ECommerceAPI.Application.Features.Queries.Order.GetByIdOrder
{
    public class GetByIdOrderQueryResponse
    {
        public string Address { get; set; }
        public object BasketItems { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public string OrderCode { get; set; }
        public bool IsCompleted { get; set; }
    }
}