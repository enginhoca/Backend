using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Common.Dtos
{
    public class CartDto
    {
    public int Id { get; set; }
    public int BuyerId { get; set; }
    public List<CartItemDto> Items { get; set; }
    }
}