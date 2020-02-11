using CMS.Dominio.Entidades;
using CMS.Infra.EF.MAP;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infra.EF
{
    public class Context : DbContext
    {

        //public static string ConnectionString = @"Server=DESKTOP-EEQ8PMR\SQLEXPRESS;Initial Catalog=CMS_MauricioJr;MultipleActiveResultSets=true;Integrated Security=True";

        //public static string ConnectionString = @"Data Source=localhost;Initial Catalog=CMS; MultipleActiveResultSets=true;Integrated Security=True";

        //public static string ConnectionString = @"Server=68.66.228.7;Database=sousasil_cms_mauricio_jr;User Id=sousasil_admin;Password=Siga2018;";

        //Producao local
        public static string ConnectionString = @"Server=127.0.0.1;Port=5432;Database=CMSDev;User Id=postgres;Password=#@ijyHQ0;";

        //Desenvolvimento remoto
        //public static string ConnectionString = @"Server=167.86.112.71;Port=5432;Database=CMSDev;User Id=postgres;Password=#@ijyHQ0;";



        public DbSet<AreaWebsite> AreaWebsite { get; set; }
        public DbSet<CardParceiros> CardParceiros { get; set; }
        public DbSet<CMSFaleConosco> CMSFaleConosco { get; set; }
        public DbSet<CMShome> CMShome { get; set; }
        public DbSet<CMSParceiros> CMSParceiros { get; set; }
        public DbSet<CMSPlanos> CMSPlanos { get; set; }
        public DbSet<CMSServicos> CMSServicos { get; set; }
        public DbSet<CMSSobre> CMSSobre { get; set; }
        public DbSet<CMSTabelaDePlanos> CMSTabelaDePlanos { get; set; }
        public DbSet<ImagemGaleria> ImagemGaleria { get; set; }
        public DbSet<Website> Website { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(ConnectionString);
            optionsBuilder.UseNpgsql(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AreaWebsiteMap());
            modelBuilder.ApplyConfiguration(new CardParceirosMap());
            modelBuilder.ApplyConfiguration(new CMSFaleConoscoMap());
            modelBuilder.ApplyConfiguration(new CMSHomeMap());
            modelBuilder.ApplyConfiguration(new CMSImagemGaleriaMap());
            modelBuilder.ApplyConfiguration(new CMSParceirosMap());
            modelBuilder.ApplyConfiguration(new CMSPlanosMap());
            modelBuilder.ApplyConfiguration(new CMSServicosMap());
            modelBuilder.ApplyConfiguration(new CMSSobreMap());
            modelBuilder.ApplyConfiguration(new CMSTabelaDePlanosMap());
            modelBuilder.ApplyConfiguration(new WebsiteMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
