using CMS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Website.Models
{
    public class WebsiteViewModel
    {
        public List<AreaWebsite> AreaWebsite { get; set; }
        public List<CardParceiros> CardParceiros { get; set; }
        public CMSFaleConosco CMSFaleConosco { get; set; }
        public CMShome CMShome { get; set; }
        public CMSParceiros CMSParceiros { get; set; }
        public CMSPlanos CMSPlanos { get; set; }
        public CMSServicos CMSServicos { get; set; }
        public CMSSobre CMSSobre { get; set; }
        public List<CMSTabelaDePlanos> CMSTabelaDePlanos { get; set; }
        public List<ImagemGaleria> ImagemGaleria { get; set; }
        public CMS.Dominio.Entidades.Website Website { get; set; }
    }

    public interface IEmailConfiguration
    {
        string SmtpServer { get; }
        int SmtpPort { get; }
        string SmtpUsername { get; set; }
        string SmtpPassword { get; set; }

        string PopServer { get; }
        int PopPort { get; }
        string PopUsername { get; }
        string PopPassword { get; }
    }

    public class EmailConfiguration : IEmailConfiguration
    {
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }

        public string PopServer { get; set; }
        public int PopPort { get; set; }
        public string PopUsername { get; set; }
        public string PopPassword { get; set; }
    }
}
