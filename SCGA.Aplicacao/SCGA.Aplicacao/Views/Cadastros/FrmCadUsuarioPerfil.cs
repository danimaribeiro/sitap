using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SCGA.Aplicacao.Views.Cadastros
{
    public partial class FrmCadUsuarioPerfil : Base.CrudBase
    {
        public FrmCadUsuarioPerfil()
        {
            InitializeComponent();
            
            lblNomePerfil.Text = Properties.Resources.LblNomePerfil;
        }

        public override void SetFyiMessage(object sender, EventArgs e)
        {
            base.SetFyiMessage(sender, e);
        }

        public override void ClearFyiMessage(object sender, EventArgs e)
        {
            base.ClearFyiMessage(sender, e);
        }
    }
}
