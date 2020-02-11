using CMS.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infra.EF.MAP
{
    public class CMSSobreMap : IEntityTypeConfiguration<CMSSobre>
    {
        public void Configure(EntityTypeBuilder<CMSSobre> builder)
        {
            builder.ToTable("CMSSobre");
            builder.HasKey(x => x.ID);
        }
    }
}
