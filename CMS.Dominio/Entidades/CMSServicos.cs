using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Dominio.Entidades
{
    public class CMSServicos
    {
        public Guid ID { get; set; }
        public String Titulo { get; set; }
        public Boolean HabilitarTitulo { get; set; }
        public String SubtTitulo { get; set; }
        public Boolean SubTitulo { get; set; }
        public String Conteudo { get; set; }
        public Byte[] Imagem { get; set; }
        public String ImagemType { get; set; }
        public Boolean HabilitarImagem { get; set; }
        public Byte[] ImagemCitacao { get; set; }
        public String ImagemCitacaoType { get; set; }
        public String TextoCitacao { get; set; }
    }
}
