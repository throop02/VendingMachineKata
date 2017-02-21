using VendingMachine.Services.Interfaces;
using System.Collections.Generic;
using VendingMachine.Entities;

namespace VendingMachine.Services
{
    public class ProductProvider : IProductProvider
    {
        public List<Product> GetProducts()
        {
            var Products = new List<Product>();

            Products.Add(new Product() {
                Name = "Cola",
                Price = 1.00m,
                SelectionCode = "A"
            });

            Products.Add(new Product() {
                Name = "Chips",
                Price = 0.50m,
                SelectionCode = "B"
            });

            Products.Add(new Product() {
                Name = "Candy",
                Price = 0.65m,
                SelectionCode = "C"
            });

            return Products;
        }
    }
}