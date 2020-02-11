using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Dominio.Entidades
{
    public class CMShome
    {
        public Guid ID { get; set; }
        public String Titulo { get; set; }
        public String SubTitulo { get; set; }
        public Boolean HabilitarWhatsApp { get; set; }
        public Boolean HabilitarFacebook { get; set; }
        public Boolean HabilitarInstagram { get; set; }
        public Boolean HabilitarGoogleMais { get; set; }
        public Boolean HabilitarPinterest { get; set; }
        public Boolean HabilitarTwitter { get; set; }
        public Byte[] SlideImagem { get; set; }
        public String SlideImagemType { get; set; }
    }
}
