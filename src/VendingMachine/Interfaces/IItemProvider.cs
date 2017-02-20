using VendingMachine.Entities;
using System.Collections.Generic;


namespace VendingMachine.Interfaces
{
    public interface IItemProvider
    {
        List<Item> GetItems();        
    }
}