using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SCGA.Aplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void botaoEntrar_Click(object sender, EventArgs e)
        {

            System.Globalization.CultureInfo conversor = new System.Globalization.CultureInfo("en-US",false);

            var valor  = decimal.Parse(txtUsuario.Text, conversor);
            MessageBox.Show(valor.ToString());

            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            client.BaseAddress = new Uri("http://localhost:27543/");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var requisicao = new { Usuario = txtUsuario.Text, Senha = txtSenha.Text };

            var response = client.PostAsJsonAsync("api/Usuario", requisicao).Result;
            if (response.IsSuccessStatusCode)
            {
                var usuario = response.Content.ReadAsAsync<Dominio.Usuario>().Result;
                if (usuario != null)
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                else
                    MessageBox.Show("Usuário não encontrado!");
            }
            else
            {
                var result = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                Console.WriteLine(result);
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
