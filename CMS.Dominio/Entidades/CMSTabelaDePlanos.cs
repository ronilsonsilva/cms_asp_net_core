using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Dominio.Entidades
{
    public class CMSTabelaDePlanos
    {
        public Guid ID { get; set; }
        public String TextoHeader { get; set; }
        public String TextoFooter { get; set; }
        public String Descircao { get; set; }
        public Decimal ValorPlano { get; set; }
        public Guid IdCMSPlanos { get; set; }
        public CMSPlanos CMSPlanos { get; set; }
    }
}
