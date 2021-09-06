using EFCoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo.Dtos
{
    public class ShopItemCreate
    {
        public string Name { get; set; }
        public List<Shop> Shops { get; set; }
        public int ShopId { get; set; }

    }
}
