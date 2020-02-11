using CMS.Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class WebsiteViewModel
    {
        public Guid ID { get; set; }

        [Display(Name = "Nome")]
        public String NomeWebsite { get; set; }

        [Display(Name = "Título")]
        public String TituloHeader { get; set; }

        [Display(Name = "Ícone")]
        public IFormFile IconeArquivo { get; set; }
        public Byte[] Icone { get; set; }

        public String IconeType { get; set; }

        [Display(Name = "Branch")]
        public IFormFile LogoTopoArquivo { get; set; }
        public Byte[] LogoTopo { get; set; }
        public String LogoTopoType { get; set; }

        [Display(Name = "Número do WhatsApp")]
        public String WhatsAppNumero { get; set; }

        [Display(Name = "Link do Facebook")]
        public String FacebookURL { get; set; }

        [Display(Name = "Link Instagram")]
        public String InstagramURL { get; set; }

        [Display(Name = "Link Google+")]
        public String GoogleMaisURL { get; set; }

        [Display(Name = "Link Pinterest")]
        public String PinterestURL { get; set; }

        [Display(Name = "Link Twitter")]
        public String TwitterURL { get; set; }

        public ICollection<AreaWebsite> AreaWebsites { get; set; }

        public Usuario Usuario { get; set; }

        public static Website Mapear(WebsiteViewModel website)
        {
            if (website != null)
            {
                var saida = new Website()
                {
                    AreaWebsites = website.AreaWebsites,
                    FacebookURL = website.FacebookURL,
                    GoogleMaisURL = website.GoogleMaisURL,
                    Icone = website.Icone,
                    IconeType = website.IconeType,
                    ID = website.ID,
                    LogoTopo = website.LogoTopo,
                    InstagramURL = website.InstagramURL,
                    LogoTopoType = website.LogoTopoType,
                    NomeWebsite = website.NomeWebsite,
                    PinterestURL = website.PinterestURL,
                    TituloHeader = website.TituloHeader,
                    TwitterURL = website.TwitterURL,
                    WhatsAppNumero = website.WhatsAppNumero
                };
                return saida;
            }
            return null;
        }

        public static WebsiteViewModel Mapear(Website website)
        {
            if (website != null)
            {
                var saida = new WebsiteViewModel()
                {
                    AreaWebsites = website.AreaWebsites,
                    FacebookURL = website.FacebookURL,
                    GoogleMaisURL = website.GoogleMaisURL,
                    Icone = website.Icone,
                    IconeType = website.IconeType,
                    ID = website.ID,
                    LogoTopo = website.LogoTopo,
                    InstagramURL = website.InstagramURL,
                    LogoTopoType = website.LogoTopoType,
                    NomeWebsite = website.NomeWebsite,
                    PinterestURL = website.PinterestURL,
                    TituloHeader = website.TituloHeader,
                    TwitterURL = website.TwitterURL,
                    WhatsAppNumero = website.WhatsAppNumero
                };
                return saida;
            }
            return null;
        }
    }
}
