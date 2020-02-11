using CMS.Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class CMShomeViewModel
    {
        public Guid ID { get; set; }

        [Display(Name = "Título")]
        public String Titulo { get; set; }

        [Display(Name = "Subt Título")]
        public String SubTitulo { get; set; }

        [Display(Name = "Exibir WhatsApp")]
        public Boolean HabilitarWhatsApp { get; set; }

        [Display(Name = "Exibir Facebook")]
        public Boolean HabilitarFacebook { get; set; }

        [Display(Name = "Exibir Instagram")]
        public Boolean HabilitarInstagram { get; set; }

        [Display(Name = "Exibir Google+")]
        public Boolean HabilitarGoogleMais { get; set; }

        [Display(Name = "Exibir Pinterest")]
        public Boolean HabilitarPinterest { get; set; }

        [Display(Name = "Exibir Twitter")]
        public Boolean HabilitarTwitter { get; set; }

        [Display(Name = "Imagem")]
        public IFormFile SlideImagemArquivo { get; set; }
        public Byte[] SlideImagem { get; set; }
        public String SlideImagemType { get; set; }

        public static CMShome Mapear(CMShomeViewModel cms)
        {
            if (cms != null)
            {
                var saida = new CMShome()
                {
                    HabilitarFacebook = cms.HabilitarFacebook,
                    HabilitarGoogleMais = cms.HabilitarGoogleMais,
                    HabilitarInstagram = cms.HabilitarInstagram,
                    HabilitarPinterest = cms.HabilitarPinterest,
                    HabilitarTwitter = cms.HabilitarTwitter,
                    HabilitarWhatsApp = cms.HabilitarWhatsApp,
                    SlideImagem = cms.SlideImagem,
                    SlideImagemType = cms.SlideImagemType,
                    SubTitulo = cms.SubTitulo,
                    Titulo = cms.Titulo
                };
                return saida;
            }
            return null;
        }

        public static CMShomeViewModel Mapear(CMShome cms)
        {
            if (cms != null)
            {
                var saida = new CMShomeViewModel()
                {
                    HabilitarFacebook = cms.HabilitarFacebook,
                    HabilitarGoogleMais = cms.HabilitarGoogleMais,
                    HabilitarInstagram = cms.HabilitarInstagram,
                    HabilitarPinterest = cms.HabilitarPinterest,
                    HabilitarTwitter = cms.HabilitarTwitter,
                    HabilitarWhatsApp = cms.HabilitarWhatsApp,
                    ID = cms.ID,
                    SlideImagem = cms.SlideImagem,
                    SlideImagemType = cms.SlideImagemType,
                    SubTitulo = cms.SubTitulo,
                    Titulo = cms.Titulo
                };
                return saida;
            }
            return null;
        }
    }
}
