using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Dominio.Entidades
{
    public class ImagemGaleria
    {
        public Guid ID { get; set; }
        public Byte[] Imagem { get; set; }
        public String ImagemType { get; set; }
    }
}
