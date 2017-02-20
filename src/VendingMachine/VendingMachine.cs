using VendingMachine.Interfaces;
using System.Collections.Generic;
using VendingMachine.Entities;
using VendingMachine.Services;

namespace VendingMachine
{
    public class VendingMachine
    {
        public List<Item> GetItems()
        {

            IItemProvider p = new ItemProvider();
            return p.GetItems();

        }
    }
}