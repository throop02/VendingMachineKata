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

        public string BuildProductSelectionList()
        {
            string selection = "Selection: ";
            IProductProvider p = new ProductProvider();

            foreach (Product product in p.GetProducts())
            {
                selection += string.Format("[{0}] {1} ", product.SelectionCode, product.Name);
            }
            return selection;
        }

    }
}