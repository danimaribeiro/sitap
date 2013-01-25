using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCGA;

namespace SCGA.Aplicacao.Views.Base
{
    public abstract partial class CrudBase : Form
    {
        public ToolStripStatusLabel FyiMessage { get; set; }
        public String FormText { set { this.Text = value; } }

        protected CrudBase()
        {
            InitializeComponent();
        }

        public virtual void SetFyiMessage(object sender, EventArgs e)
        {
            FyiMessage.Text = (String)((Control)sender).Tag;
        }

        public virtual void ClearFyiMessage(object sender, EventArgs e)
        {
            FyiMessage.Text = "";
        }
    }
}
