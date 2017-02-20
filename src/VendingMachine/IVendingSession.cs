using System.Collections.Generic;
using VendingMachine.Entities;

namespace VendingMachine
{
    public interface IVendingSession
    {
         List<Product> GetProducts();
         List<Coin> GetCoins();
         List<DisplayMessage> DisplayStack { get; }
         List<Coin> CoinsInserted { get; }    
         decimal TotalInserted { get; }
    }
}