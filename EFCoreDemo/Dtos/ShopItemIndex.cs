using EFCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo.Dtos
{
    public class ShopItemIndex
    {
        [DisplayName("Shop")]
        public int ShopId { get; set; }
        public List<ShopItem> ShopItems { get; set; }
        public List<Shop> Shops { get; set; }

    }
}
