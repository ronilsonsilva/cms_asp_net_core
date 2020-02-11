using CMS.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infra.EF.MAP
{
    public class CardParceirosMap : IEntityTypeConfiguration<CardParceiros>
    {
        public void Configure(EntityTypeBuilder<CardParceiros> builder)
        {
            builder.ToTable("CardParceiros");
            builder.HasKey(x => x.ID);
        }
    }
}
