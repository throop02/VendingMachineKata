using System;
using Xunit;
using VendingMachine;
using System.Linq;
using VendingMachine.Entities;

namespace Tests
{
    public class Tests
    {

        private readonly IVendingSession _VendingSession;

        public Tests()
        {
            this._VendingSession = new VendingSession();
        }

        [Fact]
        public void VendingMachineHasThreeProductsAvailable() 
        {

            var products = _VendingSession.GetProducts();

            Assert.Equal(products.Count, 3);
            Assert.Equal(products.Any(x => x.Name == "Cola" && x.Price == 1.00m), true);
            Assert.Equal(products.Any(x => x.Name == "Chips" && x.Price == 0.50m), true);
            Assert.Equal(products.Any(x => x.Name == "Candy" && x.Price == 0.65m), true);
        }

        [Fact]
        public void VendingMachineContainsCoinDefinitions()
        {
            var coins = _VendingSession.GetCoins();
            Assert.Equal(coins.Count > 0, true);
        }

        [Fact]
        public void WhenCoinsAreInsertedTotalAmountIncreases()
        {
            var vs = new VendingSession();
            var coins = vs.GetCoins();

            foreach(Coin c in coins)
            {
                vs.InsertCoin(c.Size, c.Weight);
            }

            Assert.Equal(coins.Sum(x => x.Denomination), vs.TotalInserted);

        }

    }


}
