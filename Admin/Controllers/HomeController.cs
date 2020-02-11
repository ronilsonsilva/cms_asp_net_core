using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Admin.Models;
using CMS.Dominio.Entidades;
using CMS.Dominio.Interfaces.Repository;
using System.IO;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Admin.Controllers
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

        public HomeController(IWebsite website, ICMSFaleConosco cMSFaleConosco, ICMSHome cMSHome, ICMSImagemGaleria cMSImagemGaleria, ICMSParceiros cMSParceiros, ICMSPlanos cMSPlanos, ICMSServicos cMSServicos, ICMSSobre cMSSobre, ICMSTabelaDePlanos cMSTabelaDePlanos, ICardParceiros cardParceiros, IUsuarioRepository usuarioRepository, IAreaWebsite areaWebsite)
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
        }



        public void ConfigInicial(String Titulo)
        {
            ViewBag.Title = Titulo;
        }

        public IActionResult Index()
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }


        public IActionResult EditGeral()
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var website = _website.GetAll().FirstOrDefault();
            WebsiteViewModel model = WebsiteViewModel.Mapear(website);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditGeral(WebsiteViewModel model)
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var modelEntity = _website.GetById(model.ID);
            if (modelEntity == null || model.ID == Guid.Empty) 
            {
                modelEntity = WebsiteViewModel.Mapear(model);
                modelEntity.ID = Guid.NewGuid();
                if (model.IconeArquivo != null)
                {
                    MemoryStream ms = new MemoryStream();
                    model.IconeArquivo.OpenReadStream().CopyTo(ms);
                    modelEntity.Icone = ms.ToArray();
                    modelEntity.IconeType = model.IconeArquivo.ContentType;
                }
                if (model.LogoTopoArquivo != null)
                {
                    MemoryStream ms = new MemoryStream();
                    model.LogoTopoArquivo.OpenReadStream().CopyTo(ms);
                    modelEntity.LogoTopo = ms.ToArray();
                    modelEntity.LogoTopoType = model.LogoTopoArquivo.ContentType;
                }
                _website.Add(modelEntity);
                return RedirectToAction("Index");
            }
            else
            {
                if (model.IconeArquivo != null)
                {
                    MemoryStream ms = new MemoryStream();
                    model.IconeArquivo.OpenReadStream().CopyTo(ms);
                    modelEntity.Icone = ms.ToArray();
                    modelEntity.IconeType = model.IconeArquivo.ContentType;
                }
                if (model.LogoTopoArquivo != null)
                {
                    MemoryStream ms = new MemoryStream();
                    model.LogoTopoArquivo.OpenReadStream().CopyTo(ms);
                    modelEntity.LogoTopo = ms.ToArray();
                    modelEntity.LogoTopoType = model.LogoTopoArquivo.ContentType;
                }
                modelEntity.FacebookURL = model.FacebookURL;
                modelEntity.GoogleMaisURL = model.GoogleMaisURL;
                modelEntity.InstagramURL = model.InstagramURL;
                modelEntity.NomeWebsite = model.NomeWebsite;
                modelEntity.PinterestURL = model.PinterestURL;
                modelEntity.TituloHeader = model.TituloHeader;
                modelEntity.TwitterURL = model.TwitterURL;
                modelEntity.WhatsAppNumero = model.WhatsAppNumero;
                _website.Update(modelEntity);
                return RedirectToAction("Index");
            }
        }

        public IActionResult VisualizarIcone()
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var website = _website.GetAll().FirstOrDefault();
            if (website != null)
            {
                return File(website.Icone, website.IconeType);
            }
            return NotFound();
        }

        public IActionResult VisualizarLogo()
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var website = _website.GetAll().FirstOrDefault();
            if (website != null)
            {
                return File(website.LogoTopo, website.LogoTopoType);
            }
            return NotFound();
        }

        public IActionResult EditHome()
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var home = _cMSHome.GetAll().FirstOrDefault();
            var model = CMShomeViewModel.Mapear(home);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditHome(CMShomeViewModel model)
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var entity = _cMSHome.GetById(model.ID);
            var home = CMShomeViewModel.Mapear(model);
            
            if (model.SlideImagemArquivo != null)
            {
                MemoryStream ms = new MemoryStream();
                model.SlideImagemArquivo.OpenReadStream().CopyTo(ms);
                home.SlideImagem = ms.ToArray();
                home.SlideImagemType = model.SlideImagemArquivo.ContentType;
            }
            if (entity == null || model.ID == Guid.Empty)
            {
                _cMSHome.Add(home);
                return RedirectToAction("Index");
            }
            else
            {
                entity.SlideImagem = home.SlideImagem;
                entity.SlideImagemType = home.SlideImagemType;
                entity.HabilitarFacebook = home.HabilitarFacebook;
                entity.HabilitarGoogleMais = home.HabilitarGoogleMais;
                entity.HabilitarInstagram = home.HabilitarInstagram;
                entity.HabilitarPinterest = home.HabilitarPinterest;
                entity.HabilitarTwitter = home.HabilitarTwitter;
                entity.HabilitarWhatsApp = home.HabilitarWhatsApp;
                entity.SubTitulo = home.SubTitulo;
                entity.Titulo = home.Titulo;
                _cMSHome.Update(entity);
                return RedirectToAction("Index");
            }
        }

        public IActionResult EditParceiros()
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var model = new CardParceirosViewModel();
            model.CardParceiros = _cardParceiros.GetAll().ToList();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditParceiros(CardParceirosViewModel model)
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var card = CardParceirosViewModel.Mapear(model);
            if (model.LogoParceiroArquivo != null)
            {
                MemoryStream ms = new MemoryStream();
                model.LogoParceiroArquivo.OpenReadStream().CopyTo(ms);
                card.LogoParceiro = ms.ToArray();
                card.LogoParceiroType = model.LogoParceiroArquivo.ContentType;
                _cardParceiros.Add(card);
                return RedirectToAction("EditParceiros");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ExcluirCarParceiro(string submit)
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            if (!String.IsNullOrEmpty(submit))
            {
                var card = _cardParceiros.GetById(Guid.Parse(submit));
                if (card != null)
                {
                    _cardParceiros.Remove(card);
                }
            }
            return RedirectToAction("EditParceiros");
        }

        public IActionResult EditFaleConosco()
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var entity = _cMSFaleConosco.GetAll().FirstOrDefault();
            CMSFaleConoscoViewModel model = CMSFaleConoscoViewModel.Mapear(entity);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditFaleConosco(CMSFaleConoscoViewModel model)
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var entity = _cMSFaleConosco.GetById(model.ID);
            var cms = CMSFaleConoscoViewModel.Mapear(model);
            if (entity == null || model.ID == Guid.Empty)
            {
                _cMSFaleConosco.Add(cms);
            }
            else
            {
                entity.Email = cms.Email;
                entity.HabilitarEmail = cms.HabilitarEmail;
                entity.HabilitarLocalizacao = cms.HabilitarLocalizacao;
                entity.HabilitarWhatsApp = cms.HabilitarWhatsApp;
                entity.Localizacao = cms.Localizacao;
                _cMSFaleConosco.Update(entity);
            }
            return RedirectToAction("Index");
        }

        public IActionResult EditGaleriaFotos()
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            CMSGaleriaFotosViewModel model = new CMSGaleriaFotosViewModel();
            model.ImagensGaleria = _cMSImagemGaleria.GetAll();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditGaleriaFotos(CMSGaleriaFotosViewModel model)
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            if (model.ImagemArquivo != null)
            {
                foreach (var item in model.ImagemArquivo)
                {
                    MemoryStream ms = new MemoryStream();
                    item.OpenReadStream().CopyTo(ms);
                    var entity = new ImagemGaleria()
                    {
                        Imagem = ms.ToArray(),
                        ImagemType = item.ContentType,
                        ID = Guid.NewGuid()
                    };
                    _cMSImagemGaleria.Add(entity);
                }
            }
            
            return RedirectToAction("EditGaleriaFotos");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ExcluirimagemGaleria(String submit)
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            if (!String.IsNullOrEmpty(submit))
            {
                var entity = _cMSImagemGaleria.GetById(Guid.Parse(submit));
                if (entity != null)
                {
                    _cMSImagemGaleria.Remove(entity);
                }
            }
            return RedirectToAction("EditGaleriaFotos");
        }

        public IActionResult EditPlanos()
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var entity = _cMSPlanos.GetAll().FirstOrDefault();
            CMSPlanosViewModel model = new CMSPlanosViewModel();
            if (entity != null)
            {
                model.ID = entity.ID;
                model.SubTitulo = entity.SubTitulo;
                model.Titulo = entity.Titulo;
            }
            model.cMSTabelaDePlanos = _cMSTabelaDePlanos.GetAll();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPlanos(CMSPlanosViewModel model)
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var entity = _cMSPlanos.GetById(model.ID);
            if (entity != null)
            {
                entity.SubTitulo = model.SubTitulo;
                entity.Titulo = model.Titulo;
                _cMSPlanos.Update(entity);
            }
            else
            {
                entity = new CMSPlanos();
                entity.SubTitulo = model.SubTitulo;
                entity.Titulo = model.Titulo;
                _cMSPlanos.Add(entity);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AdicionarPlano(CMSPlanosViewModel model)
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var entity = CMSPlanosViewModel.Mapear(model.CMSTabelaDePlanos);
            entity.IdCMSPlanos = model.ID;
            _cMSTabelaDePlanos.Add(entity);
            return RedirectToAction("EditPlanos");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ExcluirTabelaDePlano(String submit)
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            if (!String.IsNullOrEmpty(submit))
            {
                var entity = _cMSTabelaDePlanos.GetById(Guid.Parse(submit));
                if (entity != null)
                {
                    _cMSTabelaDePlanos.Remove(entity);
                }
            }
            return RedirectToAction("EditPlanos");
        }

        public IActionResult EditSobre()
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var sobre = _cMSSobre.GetAll().FirstOrDefault();
            CMSSobreViewModel model = CMSSobreViewModel.Mapear(sobre);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditSobre(CMSSobreViewModel model, string conteudo)
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var sobre = CMSSobreViewModel.Mapear(model);
            var entity = _cMSSobre.GetById(model.ID);
            if (model.ImagemArquivo != null)
            {
                MemoryStream ms = new MemoryStream();
                model.ImagemArquivo.OpenReadStream().CopyTo(ms);
                sobre.Imagem = ms.ToArray();
                sobre.ImagemType = model.ImagemArquivo.ContentType;
            }
            if (model.ID == Guid.Empty)
            {
                _cMSSobre.Add(sobre);
            }
            else
            {
                
                if (entity != null)
                {
                    entity.Conteudo = sobre.Conteudo;
                    entity.HabilitarFacebook = sobre.HabilitarFacebook;
                    entity.HabilitarGoogleMais = sobre.HabilitarGoogleMais;
                    entity.HabilitarImagem = sobre.HabilitarImagem;
                    entity.HabilitarInstagram = sobre.HabilitarInstagram;
                    entity.HabilitarPinterest = sobre.HabilitarPinterest;
                    entity.HabilitarTitulo = sobre.HabilitarTitulo;
                    entity.HabilitarWhatsApp = sobre.HabilitarWhatsApp;
                    entity.Imagem = sobre.Imagem;
                    entity.ImagemType = sobre.ImagemType;
                    entity.SubTitulo = sobre.SubTitulo;
                    entity.SubtTitulo = sobre.SubtTitulo;
                    entity.Titulo = sobre.Titulo;
                    _cMSSobre.Update(entity);
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult VisualizarImageSobre()
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var entity = _cMSSobre.GetAll().FirstOrDefault(); ;
            if (entity != null)
            {
                return File(entity.Imagem, entity.ImagemType);
            }
            return NotFound();
        }

        public IActionResult VisualizarSlideImagem()
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var entity = _cMSHome.GetAll().FirstOrDefault(); ;
            if (entity != null)
            {
                return File(entity.SlideImagem, entity.SlideImagemType);
            }
            return NotFound();
        }

        public IActionResult EditServicos()
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var entity = _cMSServicos.GetAll().FirstOrDefault();
            CMSServicosViewModel model = CMSServicosViewModel.Mapear(entity);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditServicos(CMSServicosViewModel model)
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var entity = _cMSServicos.GetAll().FirstOrDefault();
            var servicos = CMSServicosViewModel.Mapear(model);
            if (model.ImagemArquivo != null)
            {
                MemoryStream ms = new MemoryStream();
                model.ImagemArquivo.OpenReadStream().CopyTo(ms);
                servicos.Imagem = ms.ToArray();
                servicos.ImagemType = model.ImagemArquivo.ContentType;
                if (entity != null)
                {
                    entity.Imagem = ms.ToArray();
                    entity.ImagemType = model.ImagemArquivo.ContentType;
                }
            }
            if (model.ImagemCitacaoArquivo != null)
            {
                MemoryStream ms = new MemoryStream();
                model.ImagemCitacaoArquivo.OpenReadStream().CopyTo(ms);
                servicos.ImagemCitacao = ms.ToArray();
                servicos.ImagemCitacaoType = model.ImagemCitacaoArquivo.ContentType;
                if (entity != null)
                {
                    entity.ImagemCitacao = ms.ToArray();
                    entity.ImagemCitacaoType = model.ImagemCitacaoArquivo.ContentType;
                }
            }
            if (entity == null || model.ID == Guid.Empty)
            {
                _cMSServicos.Add(servicos);
            }
            else
            {
                entity.Conteudo = servicos.Conteudo;
                entity.HabilitarImagem = servicos.HabilitarImagem;
                entity.HabilitarTitulo = servicos.HabilitarTitulo;
                entity.SubTitulo = servicos.SubTitulo;
                entity.SubtTitulo = servicos.SubtTitulo;
                entity.TextoCitacao = servicos.TextoCitacao;
                entity.Titulo = servicos.Titulo;
                _cMSServicos.Update(entity);
            }
            return RedirectToAction("Index");
        }

        public IActionResult VisualizarImagemServicos()
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var entity = _cMSServicos.GetAll().FirstOrDefault();
            if (entity != null)
            {
                return File(entity.Imagem, entity.ImagemType);
            }
            return NotFound();
        }

        public IActionResult VisualizarImagemCitacao()
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }

            var entity = _cMSServicos.GetAll().FirstOrDefault();
            if (entity != null)
            {
                return File(entity.ImagemCitacao, entity.ImagemCitacaoType);
            }
            return NotFound();
        }

        public IActionResult Login()
        {
            if (GetUsuario() != null)
            {
                return RedirectToAction("Index");
            }
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(String usuario, String Senha)
        {

            var usuarioLogado = _usuarioRepository.Login(email: usuario, senha: Utils.StringExtension.ConvertToMD5(Senha));
            if (usuarioLogado != null)
            {
                HttpContext.Session.SetString("usuario", JsonConvert.SerializeObject(usuarioLogado));
                return RedirectToAction("Index");
            }
            ViewBag.mensagem = "Usuario ou senha incorreto";
            return View();
        }

        public IActionResult Perfil()
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            var usuario = _usuarioRepository.GetAll().FirstOrDefault();
            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Perfil(Usuario usuario, String confirmarSenha)
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            if (!usuario.Senha.Equals(confirmarSenha))
            {
                ViewBag.msg = "Senhas incompatível";
                return View(usuario);
            }
            var entity = _usuarioRepository.GetById(usuario.ID);
            if (entity != null)
            {
                entity.Email = usuario.Email;
                entity.Nome = usuario.Nome;
                entity.Senha = Utils.StringExtension.ConvertToMD5(usuario.Senha);
                _usuarioRepository.Update(entity);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Sair()
        {
            if (GetUsuario() == null)
            {
                return RedirectToAction("Login");
            }
            HttpContext.Session.SetString("usuario", JsonConvert.SerializeObject(String.Empty));
            return RedirectToAction("Login");
        }

        public Usuario GetUsuario()
        {
            try
            {
                var empregado = HttpContext.Session.GetString("usuario");
                if (empregado != null && empregado != String.Empty)
                {
                    var usuario = JsonConvert.DeserializeObject<Usuario>(empregado);
                    return usuario;
                }
                return null;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
