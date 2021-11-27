using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Configurations
{
    class FactureConfiguration : IEntityTypeConfiguration<Facture>

    {

        public void Configure(EntityTypeBuilder<Facture> builder)
        {
            builder.HasKey(f => new
            {
                f.DateAchat,
                f.ProductFK,
                f.ClientFK
            });

            //CAN BE REPLACED WITH ANNOTATIONS
            builder.HasOne(facture => facture.MyClient)
                .WithMany(client => client.Factures)
                .HasForeignKey(facture => facture.ClientFK);
            //SAME
            builder.HasOne(facture => facture.MyProduct)
                .WithMany(prod => prod.Factures)
                .HasForeignKey(facture => facture.ProductFK);
        }
    }
}
