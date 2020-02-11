using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Dominio.Entidades
{
    public class CMSPlanos
    {
        public Guid ID { get; set; }
        public String Titulo { get; set; }
        public String SubTitulo { get; set; }
        public ICollection<CMSTabelaDePlanos> cMSTabelaDePlanos { get; set; }
    }
}
