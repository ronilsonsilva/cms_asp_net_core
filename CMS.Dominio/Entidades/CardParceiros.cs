using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Dominio.Entidades
{
    public class CardParceiros
    {
        public Guid ID { get; set; }
        public String NomeParceiro { get; set; }
        public String Descricao { get; set; }
        public Byte[] LogoParceiro { get; set; }
        public String LogoParceiroType { get; set; }
        public Boolean HabilitarWhatsApp { get; set; }
        public Boolean HabilitarFacebook { get; set; }
        public Boolean HabilitarInstagram { get; set; }
        public Boolean HabilitarGoogleMais { get; set; }
        public Boolean HabilitarPinterest { get; set; }
        public String WhatsAppNumero { get; set; }
        public String FacebookURL { get; set; }
        public String InstagramURL { get; set; }
        public String GoogleMaisURL { get; set; }
        public String PinterestURL { get; set; }
        public String TwitterURL { get; set; }
    }
}
