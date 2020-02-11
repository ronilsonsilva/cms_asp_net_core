using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Dominio.Entidades
{
    public class Usuario
    {
        public Guid ID { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
    }
}
