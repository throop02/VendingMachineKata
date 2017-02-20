using VendingMachine.Entities;

namespace VendingMachine.Services.Interfaces
{
    public interface ICommonServices
    {
         Coin CalculateCoin(int size, int weight);
    }
}