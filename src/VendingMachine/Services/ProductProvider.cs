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
                Price = 1.00m
            });

            Products.Add(new Product() {
                Name = "Chips",
                Price = 0.50m
            });

            Products.Add(new Product() {
                Name = "Candy",
                Price = 0.65m
            });

            return Products;
        }
    }
}