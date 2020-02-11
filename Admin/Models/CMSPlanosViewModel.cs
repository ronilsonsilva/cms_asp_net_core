using CMS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class CMSPlanosViewModel
    {
        public Guid ID { get; set; }

        [Display(Name = "Título")]
        public String Titulo { get; set; }

        [Display(Name = "Sub Título")]
        public String SubTitulo { get; set; }

        public String submit { get; set; }

        public CMSTabelaDePlanosViewModel CMSTabelaDePlanos { get; set; }

        public ICollection<CMSTabelaDePlanos> cMSTabelaDePlanos { get; set; }

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
