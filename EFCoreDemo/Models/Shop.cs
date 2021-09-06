﻿using System.Collections.Generic;
using System.ComponentModel;

namespace EFCoreDemo.Models
{
    public class Shop
    {
        public int Id { get; set; }
        [DisplayName("Name of the shop")]
        public string Name { get; set; }
        public List<ShopItem> ShopItems { get; set; }
    }
}
