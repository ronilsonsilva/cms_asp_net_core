using CMS.Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class CMSSobreViewModel
    {
        public Guid ID { get; set; }

        [Display(Name = "Título")]
        public String Titulo { get; set; }

        [Display(Name = "Exibir Titulo")]
        public Boolean HabilitarTitulo { get; set; }

        [Display(Name = "Sub Título")]
        public String SubtTitulo { get; set; }

        [Display(Name = "Exibir Sub Título")]
        public Boolean SubTitulo { get; set; }

        [Display(Name = "Conteúdo")]
        public String Conteudo { get; set; }

        [Display(Name = "Exibir Imagem")]
        public Boolean HabilitarImagem { get; set; }

        [Display(Name = "Imagem")]
        public IFormFile ImagemArquivo { get; set; }

        public Byte[] Imagem { get; set; }


        public String ImagemType { get; set; }

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

        public static CMSSobre Mapear(CMSSobreViewModel cms)
        {
            if (cms != null)
            {
                var saida = new CMSSobre()
                {
                    Conteudo = cms.Conteudo,
                    HabilitarFacebook = cms.HabilitarFacebook,
                    HabilitarGoogleMais = cms.HabilitarGoogleMais,
                    HabilitarImagem = cms.HabilitarImagem,
                    HabilitarInstagram = cms.HabilitarInstagram,
                    HabilitarPinterest = cms.HabilitarPinterest,
                    HabilitarTitulo = cms.HabilitarTitulo,
                    HabilitarWhatsApp = cms.HabilitarWhatsApp,
                    ID = cms.ID,
                    Imagem = cms.Imagem,
                    ImagemType = cms.ImagemType,
                    SubTitulo = cms.SubTitulo,
                    SubtTitulo = cms.SubtTitulo,
                    Titulo = cms.Titulo
                };
                return saida;
            }
            return null;
        }

        public static CMSSobreViewModel Mapear(CMSSobre cms)
        {
            if (cms != null)
            {
                var saida = new CMSSobreViewModel()
                {
                    Conteudo = cms.Conteudo,
                    HabilitarFacebook = cms.HabilitarFacebook,
                    HabilitarGoogleMais = cms.HabilitarGoogleMais,
                    HabilitarImagem = cms.HabilitarImagem,
                    HabilitarInstagram = cms.HabilitarInstagram,
                    HabilitarPinterest = cms.HabilitarPinterest,
                    HabilitarTitulo = cms.HabilitarTitulo,
                    HabilitarWhatsApp = cms.HabilitarWhatsApp,
                    ID = cms.ID,
                    Imagem = cms.Imagem,
                    ImagemType = cms.ImagemType,
                    SubTitulo = cms.SubTitulo,
                    SubtTitulo = cms.SubtTitulo,
                    Titulo = cms.Titulo
                };
                return saida;
            }
            return null;
        }
    }
}
