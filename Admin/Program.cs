using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CMS.Dominio.Entidades;
using CMS.Dominio.Interfaces.Repository;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Admin
{
    public class Program
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public Program(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
            this.ConfiugurarCMS();
        }

        public static void Main(string[] args)
        {
            CMS.Infra.EF.Context context = new CMS.Infra.EF.Context();
            if (context.Usuarios.Where(x => x.Email == "Admin").Count() == 0)
            {
                Usuario usuario = new Usuario()
                {
                    Email = "admin",
                    Nome = "Administrador",
                    Senha = Utils.StringExtension.ConvertToMD5("admin"),
                    ID = Guid.NewGuid()
                };
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();

        public void ConfiugurarCMS()
        {
            try
            {
                if (_usuarioRepository.GetAll().Where(x => x.Email == "Admin").FirstOrDefault() == null)
                {
                    Usuario usuario = new Usuario()
                    {
                        Email = "admin",
                        Nome = "Administrador",
                        Senha = Utils.StringExtension.ConvertToMD5("admin"),
                        ID = Guid.NewGuid()
                    };
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
