using CMS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class CMSFaleConoscoViewModel
    {
        public Guid ID { get; set; }

        [Display(Name = "Exibir WhatsApp")]
        public Boolean HabilitarWhatsApp { get; set; }

        [Display(Name = "Exibir E-mail")]
        public Boolean HabilitarEmail { get; set; }

        [Display(Name = "E-mail")]
        public String Email { get; set; }

        [Display(Name = "Exibir Localização")]
        public Boolean HabilitarLocalizacao { get; set; }

        [Display(Name = "Localização")]
        public String Localizacao { get; set; }

        public static CMSFaleConosco Mapear(CMSFaleConoscoViewModel cMS)
        {
            if (cMS != null)
            {
                var saida = new CMSFaleConosco()
                {
                    Email = cMS.Email,
                    HabilitarEmail = cMS.HabilitarEmail,
                    HabilitarLocalizacao = cMS.HabilitarLocalizacao,
                    HabilitarWhatsApp = cMS.HabilitarWhatsApp,
                    Localizacao = cMS.Localizacao
                };
                return saida;
            }
            return null;
        }

        public static CMSFaleConoscoViewModel Mapear(CMSFaleConosco cMS)
        {
            if (cMS != null)
            {
                var saida = new CMSFaleConoscoViewModel()
                {
                    Email = cMS.Email,
                    HabilitarEmail = cMS.HabilitarEmail,
                    HabilitarLocalizacao = cMS.HabilitarLocalizacao,
                    HabilitarWhatsApp = cMS.HabilitarWhatsApp,
                    ID = cMS.ID,
                    Localizacao = cMS.Localizacao
                };
                return saida;
            }
            return null;
        }
    }
}
