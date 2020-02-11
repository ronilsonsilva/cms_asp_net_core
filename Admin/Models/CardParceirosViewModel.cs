using CMS.Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class CardParceirosViewModel
    {
        public Guid ID { get; set; }

        [Display(Name = "Nome")]
        public String NomeParceiro { get; set; }

        [Display(Name = "Descrição")]
        public String Descricao { get; set; }

        [Display(Name = "Logomarca")]
        public IFormFile LogoParceiroArquivo { get; set; }
        public Byte[] LogoParceiro { get; set; }

        public String LogoParceiroType { get; set; }

        public String submit { get; set; }

        [Display(Name = "Exibir WhatsApp")]
        public Boolean HabilitarWhatsApp { get; set; }

        [Display(Name = "Exibir Twitter")]
        public Boolean HabilitarTwitter { get; set; }

        [Display(Name = "Exibir Facebook")]
        public Boolean HabilitarFacebook { get; set; }

        [Display(Name = "Exibir Instagram")]
        public Boolean HabilitarInstagram { get; set; }

        [Display(Name = "Exibir Google+")]
        public Boolean HabilitarGoogleMais { get; set; }

        [Display(Name = "Exibir Pinterest")]
        public Boolean HabilitarPinterest { get; set; }

        [Display(Name = "Exibir WhatsApp")]
        public String WhatsAppNumero { get; set; }

        [Display(Name = "Link Facebook")]
        public String FacebookURL { get; set; }

        [Display(Name = "Link Intagram")]
        public String InstagramURL { get; set; }

        [Display(Name = "Link Google+")]
        public String GoogleMaisURL { get; set; }

        [Display(Name = "Link Pinterest")]
        public String PinterestURL { get; set; }

        [Display(Name = "Link Twitter")]
        public String TwitterURL { get; set; }

        public List<CardParceiros> CardParceiros { get; set; }

        public static CardParceiros Mapear(CardParceirosViewModel card)
        {
            if (card != null)
            {
                var saida = new CardParceiros()
                {
                    Descricao = card.Descricao,
                    FacebookURL  = card.FacebookURL,
                    GoogleMaisURL = card.GoogleMaisURL,
                    HabilitarFacebook = card.HabilitarFacebook,
                    HabilitarGoogleMais = card.HabilitarGoogleMais,
                    HabilitarInstagram = card.HabilitarInstagram,
                    HabilitarPinterest = card.HabilitarPinterest,
                    HabilitarWhatsApp = card.HabilitarWhatsApp,
                    InstagramURL = card.InstagramURL,
                    LogoParceiroType = card.LogoParceiroType,
                    NomeParceiro = card.NomeParceiro,
                    PinterestURL = card.PinterestURL,
                    TwitterURL = card.TwitterURL,
                    WhatsAppNumero = card.WhatsAppNumero
                };
                return saida;
            }
            return null;
        }

        public static CardParceirosViewModel Mapear(CardParceiros card)
        {
            if (card != null)
            {
                var saida = new CardParceirosViewModel()
                {
                    Descricao = card.Descricao,
                    FacebookURL  = card.FacebookURL,
                    GoogleMaisURL = card.GoogleMaisURL,
                    HabilitarFacebook = card.HabilitarFacebook,
                    HabilitarGoogleMais = card.HabilitarGoogleMais,
                    HabilitarInstagram = card.HabilitarInstagram,
                    HabilitarPinterest = card.HabilitarPinterest,
                    HabilitarWhatsApp = card.HabilitarWhatsApp,
                    ID = card.ID,
                    InstagramURL = card.InstagramURL,
                    LogoParceiroType = card.LogoParceiroType,
                    NomeParceiro = card.NomeParceiro,
                    PinterestURL = card.PinterestURL,
                    TwitterURL = card.TwitterURL,
                    WhatsAppNumero = card.WhatsAppNumero
                };
                return saida;
            }
            return null;
        }
    }
}
