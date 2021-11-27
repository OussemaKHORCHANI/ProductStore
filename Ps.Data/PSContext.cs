using Microsoft.EntityFrameworkCore;
using PS.Data.Configurations;
using PS.Domain;
using System;
using System.Linq;

namespace PS.Data
{
    public class PSContext : DbContext
    {
        public PSContext()
         {
         //   Database.EnsureCreated();
         }

        public PSContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=OussemaKhorchaniDB;Integrated Security=true");
            optionsBuilder.UseLazyLoadingProxies();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Biological> Biologicals { get; set; }
        public DbSet<Chemicals> Chemicals { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Facture> Factures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CategoryConfigurations().Configure(modelBuilder.Entity<Category>());
            new ProductConfigurations().Configure(modelBuilder.Entity<Product>());
            new ChemicalConfigurations().Configure(modelBuilder.Entity<Chemicals>());
            new FactureConfiguration().Configure(modelBuilder.Entity<Facture>());
                
            foreach(var proprety in modelBuilder.Model.GetEntityTypes()
                   .SelectMany(t=> t.GetProperties()
                   .Where(t=> t.ClrType == typeof(string)
                   && t.Name.StartsWith("Name"))))
            {
                proprety.SetColumnName("MyName");
            }

            modelBuilder.Entity<Chemicals>().ToTable("Chemicals");
            modelBuilder.Entity<Biological>().ToTable("Biologicals");
        }

       

    }
}
