using CMS.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infra.EF.MAP
{
    public class AreaWebsiteMap : IEntityTypeConfiguration<AreaWebsite>
    {
        public void Configure(EntityTypeBuilder<AreaWebsite> builder)
        {
            builder.ToTable("AreaWebsite");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Website).WithMany(x => x.AreaWebsites).HasForeignKey(x => x.IdWebsite);
        }
    }
}
