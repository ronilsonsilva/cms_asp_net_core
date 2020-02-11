using CMS.Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class ImagemGaleriaViewModel
    {
        public Guid ID { get; set; }

        [Display(Name = "Imagem")]
        public IFormFile ImagemArquivo { get; set; }
        public Byte[] Imagem { get; set; }
        public String ImagemType { get; set; }


        public static ImagemGaleria Mapear(ImagemGaleriaViewModel img)
        {
            if (img != null)
            {
                var saida = new ImagemGaleria()
                {
                    ID = img.ID,
                    Imagem = img.Imagem,
                    ImagemType = img.ImagemType
                };
                return saida;
            }
            return null;
        }

        public static ImagemGaleriaViewModel Mapear(ImagemGaleria img)
        {
            if (img != null)
            {
                var saida = new ImagemGaleriaViewModel()
                {
                    ID = img.ID,
                    Imagem = img.Imagem,
                    ImagemType = img.ImagemType
                };
                return saida;
            }
            return null;
        }
    }
}
