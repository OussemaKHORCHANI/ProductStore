using System;
using System.Collections.Generic;
using PS.Data;
using PS.Domain;


namespace PS.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Provider P1 = new Provider()
            //{
            //    Email = "email@email.com",
            //    Password = "random",
            //    ConfirmPassword = "random",
            //    Id = 1,
            //    UserName = "PROVIDER 1",
            //    DateCreated = DateTime.Now
            //};

            ////EXERCICE "e"
            //string ps = P1.Password;
            //string cps = P1.ConfirmPassword;
            //bool ia = P1.IsApproved;
            ////Provider.SetIsApprovedBeta(ref ps, ref cps, ref ia);
            //P1.IsApproved = ia;
            //P1.GetDetails();

            ////Console.WriteLine("Authentification 1:" + P1.Login("PROVIDER 1", "random not"));
            //Console.WriteLine("Authentification Finale:" + P1.Login("PROVIDER 1", "random", "email@email.com"));


            //Product Produit = new Biological()
            //{
            //    Name = "New Product",
            //    Description = "New Product Description"
            //};

            //Produit.GetMyType();


            //Category cat1 = new Category() { Name = "CAT1" };
            //Category cat2 = new Category() { Name = "CAT2" };
            //Category cat3 = new Category() { Name = "CAT3" };
            //Provider prov1 = new Provider() { UserName = "PROV1" };
            //Provider prov2 = new Provider() { UserName = "PROV2" };
            //Provider prov3 = new Provider() { UserName = "PROV3" };
            //Provider prov4 = new Provider() { UserName = "PROV4" };
            //Provider prov5 = new Provider() { UserName = "PROV5" };
            //Product prod1 = new Product() { Name = "PROD1", MyCategory = cat1, Providers = new List<Provider>() { prov1, prov2, prov3 } };
            //Product prod2 = new Product() { Name = "PROD2", MyCategory = cat1, Providers = new List<Provider>() { prov1 } };
            //Product prod3 = new Product() { Name = "PROD3", MyCategory = cat3, Providers = new List<Provider>() { prov1 } };
            //Product prod4 = new Product() { Name = "PROD4", Providers = new List<Provider>() { prov3, prov4, prov5 } };
            //Product prod5 = new Product() { Name = "PROD5", MyCategory = cat2, Providers = new List<Provider>() { } };
            //Product prod6 = new Product() { Name = "PROD6", MyCategory = cat3, Providers = new List<Provider>() { prov4, prov5 } };
            //cat1.Products = new List<Product>() { prod1, prod2 };
            //cat2.Products = new List<Product>() { prod5 };
            //cat3.Products = new List<Product>() { prod3, prod6 };
            //prov1.Products = new List<Product>() { prod1, prod2, prod3 };
            //prov2.Products = new List<Product>() { prod1, prod5 };
            //prov3.Products = new List<Product>() { prod1 };
            //prov4.Products = new List<Product>() { prod4, prod6 };
            //prov5.Products = new List<Product>() { prod4, prod6 };


            //System.Console.WriteLine("détails des providers");
            //prov1.GetDetails();
            //prov2.GetDetails();
            //prov3.GetDetails();


            using (var context = new PSContext())
            {
                System.Console.WriteLine("DATABASE CREATED!");


                //CREATION DU NOUVEAU PRODUIT
                Product p = new Product()
                {
                    Name = "Product 1",
                    DateProd = DateTime.Now,
                    Description = "Description Product 1" +
                    "description1.2",
                    Price = 999
                };

                //AJOUTER LE PRODUIT
                context.Products.Add(p);

                //ENREGISTER LES MODIFICATIONS (DANS LA BASE DE DONNEES)
                context.SaveChanges();

            }

        }

        


    }
}
