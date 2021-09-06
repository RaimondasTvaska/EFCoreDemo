using EFCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo
{
    public class ShopItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public bool Deleted { get; set; } = false;
        public Shop Shop { get; set; }

        public int? ShopId { get; set; }
        public List<ShopItemItemTag> ShopItemItemTags { get; set; }
    }
}
