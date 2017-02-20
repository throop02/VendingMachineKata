using VendingMachine.Entities;
using System.Collections.Generic;


namespace VendingMachine.Services.Interfaces
{
    public interface IProductProvider
    {
        List<Product> GetProducts();        
    }
}