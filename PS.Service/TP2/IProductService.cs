using PS.Domain;
using PS.ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Service.TP2
{
   public interface IProductService :IService<Product>
    {
        // public void Add(Product p);
        //public void Remove(Product p);
        //public IList<Product> GetAll();
        public IEnumerable<Product> FindMost5ExpensiveProds();
        public float UnavailableProductsPercentage();
       // public IEnumerable<Product> GetProdsByClient(Client c);
        public void DeleteOldProducts();
       
    }
}
