using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCGA.Api
{
    public class ServicoUsuario
    {
        private Contexto.SCGAContext _contexto;

        public ServicoUsuario()
        {
            _contexto = new Contexto.SCGAContext();
        }

        public Dominio.Usuario BuscarUsuario(string usuario, string senha)
        {
            return _contexto.Usuarios.Where(x => x.UserName == usuario && x.Senha == senha).SingleOrDefault();
        }

        public Dominio.Usuario Salvar(Dominio.Usuario usuario)
        {
            //TODO efetuar validação
            if (usuario.Id == 0)
                _contexto.Usuarios.Add(usuario);
            else
                _contexto.Entry(usuario).State = System.Data.EntityState.Modified;
            _contexto.SaveChanges();
            return usuario;
        }

        public List<Dominio.Usuario> Listar()
        {
            return _contexto.Usuarios.ToList();
        }

    }
}
