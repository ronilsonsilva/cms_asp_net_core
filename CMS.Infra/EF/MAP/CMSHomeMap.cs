using CMS.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infra.EF.MAP
{
    public class CMSHomeMap : IEntityTypeConfiguration<CMShome>
    {
        public void Configure(EntityTypeBuilder<CMShome> builder)
        {
            builder.ToTable("CMSHome");
            builder.HasKey(x => x.ID);
        }
    }
}
