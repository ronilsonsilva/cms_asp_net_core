using CMS.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infra.EF.MAP
{
    public class CMSTabelaDePlanosMap : IEntityTypeConfiguration<CMSTabelaDePlanos>
    {
        public void Configure(EntityTypeBuilder<CMSTabelaDePlanos> builder)
        {
            builder.ToTable("CMSTabelaDePlanos");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.CMSPlanos).WithMany(x => x.cMSTabelaDePlanos).HasForeignKey(x => x.IdCMSPlanos);
        }
    }
}
