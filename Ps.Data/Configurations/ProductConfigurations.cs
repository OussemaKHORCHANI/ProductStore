using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Configurations
{
    class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasMany(prod => prod.Providers)
                   .WithMany(prov => prov.Products)
                   .UsingEntity(e => e.ToTable("Providings"));
            builder.HasOne(prod => prod.MyCategory)
                   .WithMany(cat => cat.Products)
                   .HasForeignKey(prod => prod.CategoryId)
                   .OnDelete(DeleteBehavior.ClientSetNull);
                   


        }
        
    }
}
