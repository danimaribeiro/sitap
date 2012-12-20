using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCGA.Api
{
    public class ServicoUsuario
    {
        private Contexto.SCGAContext _contexto;

        public ServicoUsuario(Contexto.SCGAContext contexto)
        {
            _contexto = contexto;
        }

        public Dominio.Usuario BuscarUsuario(string usuario, string senha)
        {
            return _contexto.Usuarios.Where(x => x.UserName == usuario && x.Senha == senha).SingleOrDefault();
        }

    }
}
