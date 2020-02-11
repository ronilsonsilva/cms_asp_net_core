using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CMS.Website.Models;
using CMS.Dominio.Interfaces.Repository;
using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;

namespace CMS.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebsite _website;
        private readonly ICMSFaleConosco _cMSFaleConosco;
        private readonly ICMSHome _cMSHome;
        private readonly ICMSImagemGaleria _cMSImagemGaleria;
        private readonly ICMSParceiros _cMSParceiros;
        private readonly ICMSPlanos _cMSPlanos;
        private readonly ICMSServicos _cMSServicos;
        private readonly ICMSSobre _cMSSobre;
        private readonly ICMSTabelaDePlanos _cMSTabelaDePlanos;
        private readonly ICardParceiros _cardParceiros;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IAreaWebsite _areaWebsite;
        private readonly IEmailConfiguration _emailConfiguration;

        public HomeController(IWebsite website, ICMSFaleConosco cMSFaleConosco, ICMSHome cMSHome, ICMSImagemGaleria cMSImagemGaleria, ICMSParceiros cMSParceiros, ICMSPlanos cMSPlanos, ICMSServicos cMSServicos, ICMSSobre cMSSobre, ICMSTabelaDePlanos cMSTabelaDePlanos, ICardParceiros cardParceiros, IUsuarioRepository usuarioRepository, IAreaWebsite areaWebsite, IEmailConfiguration emailConfiguration)
        {
            _website = website;
            _cMSFaleConosco = cMSFaleConosco;
            _cMSHome = cMSHome;
            _cMSImagemGaleria = cMSImagemGaleria;
            _cMSParceiros = cMSParceiros;
            _cMSPlanos = cMSPlanos;
            _cMSServicos = cMSServicos;
            _cMSSobre = cMSSobre;
            _cMSTabelaDePlanos = cMSTabelaDePlanos;
            _cardParceiros = cardParceiros;
            _usuarioRepository = usuarioRepository;
            _areaWebsite = areaWebsite;
            _emailConfiguration = emailConfiguration;
        }

        public IActionResult Index()
        {
            WebsiteViewModel model = new WebsiteViewModel();
            model.AreaWebsite = _areaWebsite.GetAll();
            model.CardParceiros = _cardParceiros.GetAll();
            model.CMSFaleConosco = _cMSFaleConosco.GetAll().FirstOrDefault();
            model.CMShome = _cMSHome.GetAll().FirstOrDefault();
            model.CMSParceiros = _cMSParceiros.GetAll().FirstOrDefault();
            model.CMSPlanos = _cMSPlanos.GetAll().FirstOrDefault();
            model.CMSServicos = _cMSServicos.GetAll().FirstOrDefault();
            model.CMSSobre = _cMSSobre.GetAll().FirstOrDefault();
            model.CMSTabelaDePlanos = _cMSTabelaDePlanos.GetAll();
            model.ImagemGaleria = _cMSImagemGaleria.GetAll();
            model.Website = _website.GetAll().FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EnviarEmail(String nome_contato, String cel_contato, String email_contato, String assunto_contato, String msg_contato)
        {
            var message = new MimeMessage();
            message.To.Add(new MailboxAddress("Mauricio Jr", "contato@mauriciojrpersonal.com.br"));
            message.From.Add(new MailboxAddress(nome_contato, email_contato));
            message.Subject = "Contato via website";
            message.Body = new TextPart(TextFormat.Html)
            {
                Text = @"<b>Remetente: </b> " + nome_contato + "<br/><b>Celular: </b> " + cel_contato + "<br/><b>E-mail: </b> " + email_contato + "<br/><b>Assunto: </b>" + assunto_contato + "<br/><b>Mensagem: </b> <br/><p>" + msg_contato + "</p><br/>"
            };
            //Be careful that the SmtpClient class is the one from Mailkit not the framework!
            using (var emailClient = new SmtpClient())
            {
                //The last parameter here is to use SSL (Which you should!)
                emailClient.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, true);

                //Remove any OAuth functionality as we won't be using it. 
                emailClient.AuthenticationMechanisms.Remove("XOAUTH2");

                emailClient.Authenticate(_emailConfiguration.SmtpUsername, _emailConfiguration.SmtpPassword);

                emailClient.Send(message);

                emailClient.Disconnect(true);
            }
            return RedirectToAction("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
