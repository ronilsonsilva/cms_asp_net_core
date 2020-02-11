using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Admin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region Injeção de Dependência
            services.AddTransient<CMS.Dominio.Interfaces.Repository.IAreaWebsite, CMS.Infra.Repository.AreaWebsiteRepository>();
            services.AddTransient<CMS.Dominio.Interfaces.Repository.ICardParceiros, CMS.Infra.Repository.CardParceirosRepository>();
            services.AddTransient<CMS.Dominio.Interfaces.Repository.ICMSFaleConosco, CMS.Infra.Repository.CMSFaleConoscoRepository>();
            services.AddTransient<CMS.Dominio.Interfaces.Repository.ICMSHome, CMS.Infra.Repository.CMSHomeRepository>();
            services.AddTransient<CMS.Dominio.Interfaces.Repository.ICMSImagemGaleria, CMS.Infra.Repository.CMSImagemGaleriaRepository>();
            services.AddTransient<CMS.Dominio.Interfaces.Repository.ICMSParceiros, CMS.Infra.Repository.CMSParceiroRepository>();
            services.AddTransient<CMS.Dominio.Interfaces.Repository.ICMSPlanos, CMS.Infra.Repository.CMSPlanosRepository>();
            services.AddTransient<CMS.Dominio.Interfaces.Repository.ICMSServicos, CMS.Infra.Repository.CMSServicosRepository>();
            services.AddTransient<CMS.Dominio.Interfaces.Repository.ICMSSobre, CMS.Infra.Repository.CMSSobreRepository>();
            services.AddTransient<CMS.Dominio.Interfaces.Repository.ICMSTabelaDePlanos, CMS.Infra.Repository.CMSTabelaDePlanosRepository>();
            services.AddTransient<CMS.Dominio.Interfaces.Repository.IUsuarioRepository, CMS.Infra.Repository.UsuarioRepository>();
            services.AddTransient<CMS.Dominio.Interfaces.Repository.IWebsite, CMS.Infra.Repository.WebsiteRepository>();
            #endregion
            services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache
            services.AddSession();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
