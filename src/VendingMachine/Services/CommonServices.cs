using VendingMachine.Services.Interfaces;
using VendingMachine.Entities;
using System.Linq;

namespace VendingMachine.Services
{
    public class CommonServices : ICommonServices
    {
        
        public Coin CalculateCoin(int Size, int Weight)
        {
            ICoinProvider cp = new CoinProvider();
            return cp.GetCoins().FirstOrDefault(x => x.Size == Size && x.Weight == Weight);
        }

    }
}