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
    }
}
