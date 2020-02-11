using CMS.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Dominio.Interfaces.Repository
{
    public interface IUsuarioRepository : IBase<Usuario>
    {
        Usuario Login(String email, String senha);

    }
}
