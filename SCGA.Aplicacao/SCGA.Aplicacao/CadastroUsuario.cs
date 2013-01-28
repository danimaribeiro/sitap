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
            gridViewUsuarios.DataSource = listaUsuarios.Resultado;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _usuario = new Dominio.Usuario();
            SetarValores();
            tabControl1.SelectTab(1);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_usuario == null)
                    _usuario = new Dominio.Usuario();
                _usuario.Nome = txtNome.Text;
                _usuario.Email = txtEmail.Text;
                _usuario.Senha = txtSenha.Text;
                _usuario.UserName = txtUsername.Text;

                _servico.Salvar(_usuario);
            }
            catch (Exception ex)
            {
                Shared.Logger.GetInstance().Log(ex);
                MessageBox.Show(ex.Message, "Erro!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _servico.Excluir(_usuario);
        }

        private void SetarValores()
        {
            txtNome.Text = _usuario.Nome;
            txtEmail.Text = _usuario.Email;
            txtUsername.Text = _usuario.UserName;
            txtSenha.Text = _usuario.Senha;
        }

        private void gridViewUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (gridViewUsuarios.SelectedRows.Count > 0)
            {
                _usuario = (Dominio.Usuario)gridViewUsuarios.SelectedRows[0].DataBoundItem;
                SetarValores();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _usuario = new Dominio.Usuario();
            SetarValores();
            tabControl1.SelectTab(0);
        }

    }
}
