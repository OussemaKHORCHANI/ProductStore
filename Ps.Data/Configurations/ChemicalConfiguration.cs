using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Configurations
{
    class ChemicalConfigurations : IEntityTypeConfiguration<Chemicals>
    {
        public void Configure(EntityTypeBuilder<Chemicals> builder)
        {
            builder.OwnsOne(e2 => e2.MyAddress , adr=> {
                adr.Property(e => e.City)
                   .IsRequired()
                   .HasColumnName("MyCity");
                adr.Property(e1 => e1.StreetAdress)
                   .IsRequired()
                   .HasColumnName("MyAdress");
                                                         
            });
            
        }
    }
}
