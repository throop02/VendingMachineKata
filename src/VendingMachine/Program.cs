using System;
using System.Linq;
using VendingMachine.Entities;

namespace VendingMachine
{
    public class Program
    {
        
        private static DateTime _lastDisplayUpdate;
        private static IVendingSession _session;
        
        public static void Main(string[] args)
        {
            Console.WriteLine("INSERT COIN: [P] Penny [N] Nickel [D] Dime [Q] Quarter [L] Looney [X] Exit");
            
            _lastDisplayUpdate = default(DateTime);
            _session = new VendingSession();
            UpdateDisplay();            
            string keyPressed = "";

            while (keyPressed != "X")
            {
                keyPressed = Console.ReadKey().Key.ToString();
                
                if (new string[] {"P","N","D","Q","L"}.Contains(keyPressed))
                {
                    InsertCoin(keyPressed);
                    UpdateDisplay();
                }
                
            }

            Console.WriteLine("Goodbye!");

        }

        private static void UpdateDisplay()
        {
            var messages = _session.DisplayStack.OrderBy(x => x.GeneratedDateTime).ToList();
            foreach(DisplayMessage m in messages)
            {
                if (m.GeneratedDateTime > _lastDisplayUpdate)
                {
                    Console.WriteLine(m.MessageText);
                }
            }
            _lastDisplayUpdate = DateTime.Now;
        }

        //Hacky sub to assign weights to coin option and notify the vending session
        private static void InsertCoin(string keyOption)
        {
            switch(keyOption)
            {
                case "P":
                _session.InsertCoin(2,2);
                break;

                case "N":
                _session.InsertCoin(3,5);
                break;
                
                case "D":
                _session.InsertCoin(1,1);
                break;

                case "Q":
                _session.InsertCoin(6,6);
                break;

                case "L":
                _session.InsertCoin(9,8);
                break;
                
            }
        }

    }
}
