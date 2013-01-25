using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SCGA;

namespace SCGA.Api
{
    public class ServicoUsuario
    {
        private readonly Contexto.SCGAContext _contexto;

        public ServicoUsuario()
        {
            _contexto = new Contexto.SCGAContext();
        }

        public Dominio.Usuario BuscarUsuario(string usuario, string senha)
        {
            return _contexto.Usuarios.SingleOrDefault(x => x.UserName == usuario && x.Senha == senha);
        }

        public Dominio.Usuario Salvar(Dominio.Usuario usuario)
        {
            //TODO efetuar validação
            if (usuario.Id == 0)
            {
                usuario.DataCriacao = DateTime.Now;
                usuario.UltimaAtualizacao = DateTime.Now;
                usuario.Codigo = _contexto.Usuarios.Max(x => x.Codigo) + 1;

                _contexto.Usuarios.Add(usuario);
            }
            else
            {
                usuario.UltimaAtualizacao = DateTime.Now;
                _contexto.Entry(usuario).State = System.Data.EntityState.Modified;
            }
                        
            _contexto.SaveChanges();
            return usuario;
        }

        public Dominio.Common.ResultadoPaginado<List<Dominio.Usuario>> Listar(Dominio.Common.Filtro filtros)
        {
            var consulta = _contexto.Usuarios.Skip(filtros.Pagina * filtros.QuantidadePagina).Take(filtros.QuantidadePagina);
            //TODO Achar uma maneira de passar a string de filtros diretamente para a consulta;
            return new Dominio.Common.ResultadoPaginado<List<Dominio.Usuario>>(consulta.ToList(), consulta.Count(), filtros);            
        }

        public List<Dominio.Menu> RetornarMenusPermitidos(Dominio.Usuario usuario)
        {
            var lista = from p in _contexto.MenusPerfilUsuario.Where(x => x.Perfil.Id == usuario.PerfilUsuario_Id)
                        select p.MenuPermitido;

            return lista.ToList();
        }
    }
}
