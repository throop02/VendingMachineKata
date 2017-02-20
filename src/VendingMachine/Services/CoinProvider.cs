using VendingMachine.Services.Interfaces;
using VendingMachine.Entities;
using System.Collections.Generic;

namespace VendingMachine.Services
{
    public class CoinProvider : ICoinProvider
    {
        
        public List<Coin> GetCoins()
        {

            var Coins = new List<Coin>();

            Coins.Add(new Coin() 
            {
                Weight = 2,
                Size = 2,
                Denomination = 0.01m,
                Name = "Penny"
            });

            Coins.Add(new Coin() 
            {
                Weight = 5,
                Size = 3,
                Denomination = 0.05m,
                Name = "Nickel"
            });

            Coins.Add(new Coin() 
            {
                Weight = 1,
                Size = 1,
                Denomination = 0.10m,
                Name = "Dime"
            });

            Coins.Add(new Coin() 
            {
                Weight = 6,
                Size = 6,
                Denomination = 0.10m,
                Name = "Quarter"
            });

            return Coins;
        }

    }
}