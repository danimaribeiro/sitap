using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCGA.Aplicacao.Shared
{
    public class Configuracao
    {
        private static Dominio.Usuario _usuario;
        private static List<Dominio.Menu> _menus;

        public static void SetarUsuarioAplicacao(Dominio.Usuario usuario)
        {
            if (_usuario == null)
                _usuario = usuario;
            else
                throw new InvalidOperationException("Você não pode mudar o usuário da aplicação!");
        }

        public static Dominio.Usuario UsuarioAplicacao
        {
            get
            {
                return _usuario;
            }
        }

        public static List<Dominio.Menu> MenusUsuario
        {
            get
            {
                if (_menus == null)
                    throw new Exception("Os menus ainda não foram carregados.");
                return _menus;
            }
        }

        public static void CarregarMenusUsuario()
        {
            Api.ServicoUsuario servico = new Api.ServicoUsuario();
            _menus = servico.RetornarMenusPermitidos(_usuario);
        }

    }
}
