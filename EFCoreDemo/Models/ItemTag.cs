using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo.Models
{
    public class ItemTag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<ShopItemItemTag> ShopItemItemTags { get; set; }
    }
}
