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
         List<Coin> CoinsRejected { get; }  
         decimal TotalInserted { get; }
         void InsertCoin(int Size, int Weight);
         bool TryPurchaseProduct(string SelectionCode);
         decimal CalculateChange(decimal ProductPrice);
    }
}