using VendingMachine.Interfaces;
using System.Collections.Generic;
using VendingMachine.Entities;

namespace VendingMachine.Services
{
    public class ItemProvider : IItemProvider
    {
        public List<Item> GetItems()
        {
            var Items = new List<Item>();

            Items.Add(new Item() {
                Name = "Snickers",
                Price = 1.00m
            });

            Items.Add(new Item() {
                Name = "Twix",
                Price = 1.50m
            });

            return Items;
        }
    }
}