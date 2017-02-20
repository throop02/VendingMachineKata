using VendingMachine.Services.Interfaces;
using System.Collections.Generic;
using VendingMachine.Entities;
using VendingMachine.Services;
using System.Linq;

namespace VendingMachine
{
    public class VendingSession : IVendingSession
    {
        
        public VendingSession()
        {
            this._coinsInserted = new List<Coin>();
            this._displayStack = new List<DisplayMessage>();
            this._commonServices = new CommonServices();
            this._coinsRejected = new List<Coin>();
        }
        
        private List<DisplayMessage> _displayStack;
        private List<Coin> _coinsInserted;
        private List<Coin> _coinsRejected;
        private ICommonServices _commonServices;

        public List<DisplayMessage> DisplayStack { get { return this._displayStack; } }
        public List<Coin> CoinsInserted { get { return this._coinsInserted; } }
        public List<Coin> CoinsRejected { get { return this._coinsRejected; } }
        
        public decimal TotalInserted
        {
            get
            {
                return CoinsInserted.Sum(x => x.Denomination);
            }
        }

        public List<Product> GetProducts()
        {

            IProductProvider p = new ProductProvider();
            return p.GetProducts();

        }

        public List<Coin> GetCoins()
        {

            ICoinProvider p = new CoinProvider();
            return p.GetCoins();

        }

        public void InsertCoin(int Size, int Weight)
        {
            var coin = _commonServices.CalculateCoin(Size, Weight);
            if (coin == null)
            {
                this._displayStack.Add(new DisplayMessage("This machine does not take washers and Canadian change"));
            }
            else
            {
                if (coin.RejectCoin) { this._coinsRejected.Add(coin); } else { this._coinsInserted.Add(coin); }
            }
        }

    }
}