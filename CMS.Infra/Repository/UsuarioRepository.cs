using CMS.Dominio.Entidades;
using CMS.Dominio.Interfaces.Repository;
using CMS.Infra.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Infra.Repository
{
    public class UsuarioRepository : Base<Usuario>, IUsuarioRepository
    {
        private readonly Context Db = new Context();

        public Usuario Login(string email, string senha)
        {
            return Db.Usuarios.Where(x => x.Senha == senha && x.Email == email).FirstOrDefault();
        }
    }
}
