using CMS.Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class CMSGaleriaFotosViewModel
    {
        public Guid ID { get; set; }

        [Display(Name = "Título")]
        public String Titulo { get; set; }

        public String submit { get; set; }

        public List<ImagemGaleria> ImagensGaleria { get; set; }

        [Display(Name = "Arquivo Imagem")]
        public ICollection<IFormFile> ImagemArquivo { get; set; }

        public Byte[] Imagem { get; set; }

        [Display(Name = "Tipo do Arquivo")]
        public String ImagemType { get; set; }

        
    }
}
