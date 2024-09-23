using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int BuyerId { get; set; }
        public Buyer Buyer { get; set; }
        public List<CartItem> Items { get; set; }
    }


}