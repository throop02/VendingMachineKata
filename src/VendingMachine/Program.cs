using System;
using VendingMachine.Entities;

namespace VendingMachine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var vm = new VendingSession();
            

            foreach(Product i in vm.GetProducts())
            {
                Console.WriteLine(string.Format("Name: {0} Price: {1}", i.Name, i.Price));
            }

            Console.WriteLine("Please make a selection:");
            Console.Read();
        }

        

    }
}
