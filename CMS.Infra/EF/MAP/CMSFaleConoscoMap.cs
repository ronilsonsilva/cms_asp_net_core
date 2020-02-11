using CMS.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infra.EF.MAP
{
    public class CMSFaleConoscoMap : IEntityTypeConfiguration<CMSFaleConosco>
    {
        public void Configure(EntityTypeBuilder<CMSFaleConosco> builder)
        {
            builder.ToTable("CMSFaleConosco");
            builder.HasKey(x => x.ID);
        }
    }
}
