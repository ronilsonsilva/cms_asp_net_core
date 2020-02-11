using CMS.Dominio.Entidades;
using CMS.Dominio.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infra.EF.MAP
{
    public class CMSImagemGaleriaMap : IEntityTypeConfiguration<ImagemGaleria>
    {
        public void Configure(EntityTypeBuilder<ImagemGaleria> builder)
        {
            builder.ToTable("ImagemGaleria");
            builder.HasKey(x => x.ID);
        }
    }
}
