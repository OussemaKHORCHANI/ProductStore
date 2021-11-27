using PS.Data;
using PS.Data.Infrastructures;
using PS.Domain;
using PS.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Service.TP2
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork utwk) : base(utwk)
        {
        }

        

        public IEnumerable<Product> FindMost5ExpensiveProds()
        {

            //var query = from p in GetMany()
            //            orderby (p.Price) descending
            //            select p;
            // return query.Take(5);

            //expression lambda : 
            return GetMany().OrderByDescending(p => p.Price).Take(5);
        }


        public float UnavailableProductsPercentage()
        {
            int total = GetMany().Count();
            int epuise = GetMany(p => p.Quantity == 0).Count();
            return ((float)epuise / total) * 100;
        }




        public void DeleteOldProducts()
        {
            IEnumerable<Product> oldProd = GetMany(p => (DateTime.Now - p.DateProd).TotalDays >= 365);

            foreach (Product P in oldProd)
            {
                Delete(P);
            }

        }

        //public IEnumerable<Product> GetProdsByClient(Client c)
        //{
        //    ServiceFacture fs = new ServiceFacture();

        //    return  fs.GetMany(f => f.ClientFK == c.Cin)
        //              .Select(f => f.MyProduct);

        //}
    }
}
