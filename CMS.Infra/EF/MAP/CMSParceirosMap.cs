using CMS.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infra.EF.MAP
{
    public class CMSParceirosMap : IEntityTypeConfiguration<CMSParceiros>
    {
        public void Configure(EntityTypeBuilder<CMSParceiros> builder)
        {
            builder.ToTable("CMSParceiros");
            builder.HasKey(x => x.ID);
        }
    }
}
