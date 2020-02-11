using CMS.Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class CMSServicosViewModel
    {
        public Guid ID { get; set; }

        [Display(Name = "Título")]
        public String Titulo { get; set; }

        [Display(Name = "Exibir Título")]
        public Boolean HabilitarTitulo { get; set; }

        [Display(Name = "Sub Título")]
        public String SubtTitulo { get; set; }

        [Display(Name = "Exibir Sub Título")]
        public Boolean SubTitulo { get; set; }

        [Display(Name = "Conteúdo")]
        public String Conteudo { get; set; }

        [Display(Name = "Imagem do card")]
        public IFormFile ImagemArquivo { get; set; }
        public Byte[] Imagem { get; set; }
        public String ImagemType { get; set; }

        [Display(Name = "Exibir Imagem")]
        public Boolean HabilitarImagem { get; set; }

        [Display(Name = "Imagem Citação")]
        public IFormFile ImagemCitacaoArquivo { get; set; }

        public Byte[] ImagemCitacao { get; set; }

        public String ImagemCitacaoType { get; set; }

        [Display(Name = "Texto Citação")]
        public String TextoCitacao { get; set; }

        public static CMSServicos Mapear(CMSServicosViewModel cms)
        {
            if (cms != null)
            {
                var saida = new CMSServicos()
                {
                    Conteudo = cms.Conteudo,
                    HabilitarImagem = cms.HabilitarImagem,
                    HabilitarTitulo = cms.HabilitarTitulo,
                    ID = cms.ID,
                    Imagem = cms.Imagem,
                    ImagemCitacao = cms.ImagemCitacao,
                    ImagemCitacaoType = cms.ImagemCitacaoType,
                    ImagemType = cms.ImagemType,
                    SubTitulo = cms.SubTitulo,
                    SubtTitulo = cms.SubtTitulo,
                    TextoCitacao = cms.TextoCitacao,
                    Titulo = cms.Titulo
                };
                return saida;
            }
            return null;
        }

        public static CMSServicosViewModel Mapear(CMSServicos cms)
        {
            if (cms != null)
            {
                var saida = new CMSServicosViewModel()
                {
                    Conteudo = cms.Conteudo,
                    HabilitarImagem = cms.HabilitarImagem,
                    HabilitarTitulo = cms.HabilitarTitulo,
                    ID = cms.ID,
                    Imagem = cms.Imagem,
                    ImagemCitacao = cms.ImagemCitacao,
                    ImagemCitacaoType = cms.ImagemCitacaoType,
                    ImagemType = cms.ImagemType,
                    SubTitulo = cms.SubTitulo,
                    SubtTitulo = cms.SubtTitulo,
                    TextoCitacao = cms.TextoCitacao,
                    Titulo = cms.Titulo
                };
                return saida;
            }
            return null;
        }
    }
}
