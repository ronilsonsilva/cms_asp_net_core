using CMS.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infra.EF.MAP
{
    public class CMSServicosMap : IEntityTypeConfiguration<CMSServicos>
    {
        public void Configure(EntityTypeBuilder<CMSServicos> builder)
        {
            builder.ToTable("CMSServicos");
            builder.HasKey(x => x.ID);
        }
    }
}
