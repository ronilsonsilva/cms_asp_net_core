using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Dominio.Entidades
{
    public class Website
    {
        public Guid ID { get; set; }
        public String NomeWebsite { get; set; }
        public String TituloHeader { get; set; }
        public Byte[] Icone { get; set; }
        public String IconeType { get; set; }
        public Byte[] LogoTopo { get; set; }
        public String LogoTopoType { get; set; }
        public String WhatsAppNumero { get; set; }
        public String FacebookURL { get; set; }
        public String InstagramURL { get; set; }
        public String GoogleMaisURL { get; set; }
        public String PinterestURL { get; set; }
        public String TwitterURL { get; set; }

        public ICollection<AreaWebsite> AreaWebsites { get; set; }
        public Guid? IdCMSFaleConosco { get; set; }
        public CMSFaleConosco CMSFaleConosco { get; set; }
        public Guid? IdCMSGaleriaFotos { get; set; }
        public Guid? IdCMSHome { get; set; }
        public CMShome CMShome { get; set; }
        public Guid? IdCMSParceiros { get; set; }
        public CMSParceiros CMSParceiros { get; set; }
        public Guid? IdCMSPlanos { get; set; }
        public CMSPlanos CMSPlanos { get; set; }
        public Guid? IdCMSServiso { get; set; }
        public CMSServicos CMSServicos { get; set; }
    }
}
