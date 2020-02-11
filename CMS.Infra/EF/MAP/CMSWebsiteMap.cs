using CMS.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infra.EF.MAP
{
    public class WebsiteMap : IEntityTypeConfiguration<Website>
    {
        public void Configure(EntityTypeBuilder<Website> builder)
        {
            builder.ToTable("Website");
            builder.HasKey(x => x.ID);
            builder.HasMany(x => x.AreaWebsites).WithOne(x => x.Website).HasForeignKey(x => x.IdWebsite);
        }
    }
}
