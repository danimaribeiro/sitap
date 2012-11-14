using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POC
{
    public partial class CadastroUsuarios : Form
    {
        public CadastroUsuarios()
        {
            InitializeComponent();
        }

        private async void CadastroUsuarios_Load(object sender, EventArgs e)
        {            
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:3218/");
            HttpResponseMessage response = await client.GetAsync("api/Usuario");
            Dominio.Usuario[] usuarios = await response.Content.ReadAsAsync<Dominio.Usuario[]>();
            dataGridView1.DataSource = usuarios;
        }
    }
}
