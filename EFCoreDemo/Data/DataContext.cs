﻿using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Data
{
    public class DataContext : DbContext
    {
        public DbSet<ShopItem> ShopItems { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ItemTag> ItemTags { get; set; }
        public DbSet<ShopItemItemTag> ShopItemItemTags { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShopItem>()
                .Property(b => b.Price)
                .HasPrecision(20, 2);

            modelBuilder.Entity<Shop>()
                .HasMany(s => s.ShopItems)
                .WithOne(si => si.Shop)
                .HasForeignKey(si => si.ShopId);

            modelBuilder.Entity<ShopItemItemTag>()
                .HasKey(bc => new { bc.ShopItemId, bc.TagId });

        }

    }
}
