using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SCGA.Dominio.Common;

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
            {
                usuario.Sessao = Guid.NewGuid().ToString();
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

        public void Excluir(Dominio.Usuario usuario)
        {
           var deletar =  _contexto.Usuarios.Find(usuario.Id);
           if (deletar != null)
           {
               _contexto.Usuarios.Remove(deletar);
               _contexto.SaveChanges();
           }
           else
               throw new Exception("O registro não existe!");
        }

        public ResultadoPaginado<List<Dominio.Usuario>> Listar(Filtro filtros)
        {
            var consulta = _contexto.Usuarios.OrderBy(x=>x.Nome).Take(filtros.QuantidadePagina).Skip((filtros.Pagina -1) * filtros.QuantidadePagina);
            //TODO Achar uma maneira de passar a string de filtros diretamente para a consulta;
            return new ResultadoPaginado<List<Dominio.Usuario>>(consulta.ToList(), consulta.Count(), filtros);            
        }

        public List<Dominio.Menu> RetornarMenusPermitidos(Dominio.Usuario usuario)
        {
            var lista = from p in _contexto.MenusPerfilUsuario.Where(x => x.Perfil.Id == usuario.PerfilUsuario_Id)
                        select p.MenuPermitido;

            return lista.ToList();
        }
    }
}
