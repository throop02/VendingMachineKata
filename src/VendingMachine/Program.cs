using System;
using VendingMachine.Entities;
using VendingMachine.Interfaces;
using VendingMachine.Services;

namespace VendingMachine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var vm = new VendingMachine();

            foreach(Item i in vm.GetItems())
            {
                Console.WriteLine(string.Format("Name: {0} Price: {1}", i.Name, i.Price));
            }

            Console.WriteLine("Please make a selection:");
            Console.Read();
        }

        

    }
}
