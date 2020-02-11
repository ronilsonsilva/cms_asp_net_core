using CMS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class CMSTabelaDePlanosViewModel
    {
        public Guid ID { get; set; }

        [Display(Name = "Título")]
        public String TextoHeader { get; set; }

        [Display(Name = "Texto Inferior")]
        public String TextoFooter { get; set; }

        [Display(Name = "Descrição")]
        public String Descircao { get; set; }

        [Display(Name = "Valor")]
        public Decimal ValorPlano { get; set; }

        public Guid IdCMSPlanos { get; set; }
        public CMSPlanos CMSPlanos { get; set; }

        public static CMSTabelaDePlanosViewModel Mapear(CMSTabelaDePlanos cms)
        {
            if (cms != null)
            {
                var saida = new CMSTabelaDePlanosViewModel()
                {
                    CMSPlanos = cms.CMSPlanos,
                    Descircao = cms.Descircao,
                    ID = cms.ID,
                    IdCMSPlanos = cms.IdCMSPlanos,
                    TextoFooter = cms.TextoFooter,
                    TextoHeader = cms.TextoHeader,
                    ValorPlano = cms.ValorPlano
                };
                return saida;
            }
            return null;
        }

        public static CMSTabelaDePlanos Mapear(CMSTabelaDePlanosViewModel cms)
        {
            if (cms != null)
            {
                var saida = new CMSTabelaDePlanos()
                {
                    CMSPlanos = cms.CMSPlanos,
                    Descircao = cms.Descircao,
                    ID = cms.ID,
                    IdCMSPlanos = cms.IdCMSPlanos,
                    TextoFooter = cms.TextoFooter,
                    TextoHeader = cms.TextoHeader,
                    ValorPlano = cms.ValorPlano
                };
                return saida;
            }
            return null;
        }
    }
}
