using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCGA.Aplicacao
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var janelaUsuario = new CadastroUsuario();
            janelaUsuario.MdiParent = this;
            janelaUsuario.WindowState = FormWindowState.Maximized;
            janelaUsuario.Show();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            Shared.Configuracao.CarregarMenusUsuario();
            var listaMenus = Shared.Configuracao.MenusUsuario;
            listaMenus = listaMenus.OrderBy(x => x.Sequencia).ToList();
            MontarMenu(listaMenus);
        }

        private void MontarMenu(List<Dominio.Menu> menus)
        {
            foreach (var item in menus)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(item.Nome);
                menuItem.Tag = item;
                if (!string.IsNullOrWhiteSpace(item.Formulario))
                {
                    menuItem.Click += new EventHandler(AbrirFormulario);
                    this.menuStrip1.Items.Add(menuItem);
                }
            }
        }

        private void AbrirFormulario(System.Object sender, System.EventArgs e)
        {
            try
            {
                Dominio.Menu menu = (Dominio.Menu)((ToolStripMenuItem)sender).Tag;
                this.CriarAbrirInstanciaForm(menu.Formulario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Shared.Logger.GetInstance().Log(ex);
            }
        }

        private void CriarAbrirInstanciaForm(string formulario)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetEntryAssembly();
            string nomeNamespace = assembly.GetName().Name;
            nomeNamespace = nomeNamespace + "." + formulario;

            Type tipoFormulario = assembly.GetType(nomeNamespace);
            if (tipoFormulario != null)
            {
                Form instanciaFormulario = (Form)Activator.CreateInstance(tipoFormulario);
                for (int i = 0; i < this.MdiChildren.Count(); i++)
                {
                    var r = this.MdiChildren[i];
                    if (r.Name == instanciaFormulario.Name)
                    {
                        r.Focus();
                        return;
                    }
                }
                instanciaFormulario.MdiParent = this;
                instanciaFormulario.BringToFront();
                instanciaFormulario.WindowState = FormWindowState.Maximized;
                instanciaFormulario.Show();
            }
            else
                throw new Exception(string.Format("O formulario {0} não existe. Verifique o cadastro de menu.", formulario));
        }

    }
}
