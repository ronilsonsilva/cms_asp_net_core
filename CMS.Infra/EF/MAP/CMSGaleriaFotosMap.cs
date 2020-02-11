using CMS.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infra.EF.MAP
{
    //public class CMSGaleriaFotosMap : IEntityTypeConfiguration<CMSGaleriaFotos>
    //{
    //    public void Configure(EntityTypeBuilder<CMSGaleriaFotos> builder)
    //    {
    //        builder.ToTable("CMSGaleriaFotos");
    //        builder.HasKey(x => x.ID);
    //        builder.HasMany(x => x.ImagensGaleria).WithOne(x => x.CMSGaleriaFotos).HasForeignKey(x => x.ID);
    //    }
    //}
}
