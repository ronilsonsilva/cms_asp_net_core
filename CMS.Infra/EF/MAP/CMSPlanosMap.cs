using CMS.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infra.EF.MAP
{
    public class CMSPlanosMap : IEntityTypeConfiguration<CMSPlanos>
    {
        public void Configure(EntityTypeBuilder<CMSPlanos> builder)
        {
            builder.ToTable("CMSPlanos");
            builder.HasKey(x => x.ID);
        }
    }
}
