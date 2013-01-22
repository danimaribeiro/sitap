using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCGA.Api;

namespace SCGA.Aplicacao
{
    public partial class CadastroUsuario : Form
    {
        private ServicoUsuario _servico;
        private Dominio.Usuario _usuario;

        public CadastroUsuario()
        {
            InitializeComponent();
            _servico = new ServicoUsuario();
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            var listaUsuarios = _servico.Listar(new Dominio.Common.Filtro("Nome") { });
            gridViewUsuarios.DataSource = listaUsuarios;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _usuario.Nome = txtNome.Text;
            _usuario.Email = txtEmail.Text;
            _usuario.Senha = txtSenha.Text;
            _usuario.UserName = txtUsername.Text;

            _servico.Salvar(_usuario);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }




    }
}
