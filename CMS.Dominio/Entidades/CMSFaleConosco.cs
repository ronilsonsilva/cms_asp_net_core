using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Dominio.Entidades
{
    public class CMSFaleConosco
    {
        public Guid ID { get; set; }
        public Boolean HabilitarWhatsApp { get; set; }
        public Boolean HabilitarEmail { get; set; }
        public String Email { get; set; }
        public Boolean HabilitarLocalizacao { get; set; }
        public String Localizacao { get; set; }
    }
}
