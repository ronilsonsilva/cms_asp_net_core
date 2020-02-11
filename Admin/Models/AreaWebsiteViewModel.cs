using CMS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class AreaWebsiteViewModel
    {
        public Guid ID { get; set; }

        [Display(Name = "Exibir no site")]
        public Boolean Ativo { get; set; }

        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Display(Name = "ID do HTML")]
        public String IdHtml { get; set; }

        [Display(Name = "Website")]
        public Guid IdWebsite { get; set; }

        public List<AreaWebsite> AreaWebsites { get; set; }

        public WebsiteViewModel Website { get; set; }

        public static AreaWebsite Mapear(AreaWebsiteViewModel areaWebsite)
        {
            if (areaWebsite != null)
            {
                var saida = new AreaWebsite()
                {
                    Ativo = areaWebsite.Ativo,
                    ID = areaWebsite.ID,
                    IdHtml = areaWebsite.IdHtml,
                    IdWebsite = areaWebsite.IdWebsite,
                    Nome = areaWebsite.Nome
                };
                return saida;
            }
            return null;
        }

        public static AreaWebsiteViewModel Mapear(AreaWebsite areaWebsite)
        {
            if (areaWebsite != null)
            {
                var saida = new AreaWebsiteViewModel()
                {
                    Ativo = areaWebsite.Ativo,
                    ID = areaWebsite.ID,
                    IdHtml = areaWebsite.IdHtml,
                    IdWebsite = areaWebsite.IdWebsite,
                    Nome = areaWebsite.Nome
                };
                return saida;
            }
            return null;
        }
    }
}
