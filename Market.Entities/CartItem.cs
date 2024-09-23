using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Market.Service;

namespace Market.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}