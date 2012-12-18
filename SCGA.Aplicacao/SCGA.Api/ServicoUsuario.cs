using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCGA.Api
{
    public class ServicoUsuario
    {
        private Contexto.Entity_Contexto _contexto;

        public ServicoUsuario(Contexto.Entity_Contexto contexto)
        {
            _contexto = contexto;
        }

        public Dominio.Usuario BuscarUsuario(string usuario, string senha)
        {
            return _contexto.Usuarios.Where(x => x.Username == usuario && x.Senha == senha).SingleOrDefault();
        }

    }
}
