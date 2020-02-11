using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Dominio.Entidades
{
    public class AreaWebsite
    {
        public Guid ID { get; set; }
        public Boolean Ativo { get; set; }
        public String Nome { get; set; }
        public String IdHtml { get; set; }
        public Guid IdWebsite { get; set; }
        public Website Website { get; set; }
    }
}
