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
            Assert.Equal(true, products.Any(x => x.Name == "Cola" && x.Price == 1.00m));
            Assert.Equal(true, products.Any(x => x.Name == "Chips" && x.Price == 0.50m));
            Assert.Equal(true, products.Any(x => x.Name == "Candy" && x.Price == 0.65m));
        }

        [Fact]
        public void VendingMachineContainsCoinDefinitions()
        {
            var coins = _VendingSession.GetCoins();
            Assert.Equal(true, coins.Count > 0);
        }

        [Fact]
        public void WhenValidCoinsAreInsertedTotalAmountIncreases()
        {
            IVendingSession vs = new VendingSession();
            var coins = vs.GetCoins().Where(x => x.RejectCoin == false);

            foreach(Coin c in coins)
            {
                vs.InsertCoin(c.Size, c.Weight);
            }

            Assert.Equal(coins.Sum(x => x.Denomination), vs.TotalInserted);

        }

        [Fact]
        public void PennyIsRejected()
        {
            IVendingSession vs = new VendingSession();
            var penny = vs.GetCoins().Single(x => x.Name == "Penny" && x.RejectCoin == true);
            vs.InsertCoin(penny.Size, penny.Weight);

            //Amount did not increase
            Assert.Equal(0.00m, vs.TotalInserted);

            //Penny got added to reject collection
            Assert.Equal(penny.Denomination, vs.CoinsRejected.Sum(x => x.Denomination));
        }

        [Fact]
        public void DisplayAmountIsUpdatedWhenValidCoinIsInserted()
        {
            IVendingSession vs = new VendingSession();
            var coin = vs.GetCoins().First(x => x.RejectCoin == false);
            vs.InsertCoin(coin.Size, coin.Weight);

            Assert.Equal((" Amount: " + coin.Denomination.ToString("c")), vs.DisplayStack.OrderByDescending(x => x.GeneratedDateTime).First().MessageText);

        }


    }


}
