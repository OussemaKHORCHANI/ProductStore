using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Service
{
   public class ManageProduct
    {

        

        public static List<Product> Products;

        public void ManagerProducts(List<Product> products)
        {
            Products = products;
        }

        public IEnumerable<Product> Get5Chemical(double price)
        {
            var query = from P in Products
                        where P is Chemicals
                        where P.Price >= price
                        select P;
            return query.Take(5);
        }

        public IEnumerable<Product> GetProductPrice(double price)
        {
            var query = from P in Products
                        where P.Price >= price
                        select P;
            return query.Skip(2);
        }

        public float GetAveragePrice()
        {
            var query = from P in Products
                        select P.Price;
            return (float)query.Average();
        }

        public double GetMaxPrice()
        {
            var query = from P in Products
                        select P.Price;
            return (double)query.Max();
        }

        public int GetCountProduct(string city)
        {
            var query = from P in Products.OfType<Chemicals>()
                        where P.MyAddress.Equals(city)
                        select P;
            return query.Count();
        }

        public IEnumerable<Product> GetChemicalCity()
        {
            var query = from P in Products.OfType<Chemicals>()
                        orderby (P.MyAddress) ascending
                        select P;
            return query;
        }

        public IEnumerable<Product> GetChemicalGroupByCity()
        {
            var query = from P in Products.OfType<Chemicals>()
                        orderby (P.MyAddress) ascending
                        group P by P.MyAddress into c
                        select c;
            return (IEnumerable<Product>)query;
        }

        public Func<string, List<Product>> FindProduct = (string ch) => {
            List<Product> pl = new List<Product>();
            foreach (Product P in Products)
            {
                if (P.Name.StartsWith(ch))
                {
                    pl.Add(P);
                }
            }
            return pl;
        };

    }
}
