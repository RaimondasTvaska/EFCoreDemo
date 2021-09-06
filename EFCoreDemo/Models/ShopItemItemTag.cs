using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo.Models
{
    public class ShopItemItemTag
    {
        public int ShopItemId { get; set; }
        public ShopItem ShopItem { get; set; }
        public int  TagId { get; set; }
        public ItemTag Tag { get; set; }
    }
}
