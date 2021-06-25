using DotNetSorteio.Site.WebForm.Functions;
using DotNetSorteios.Servicos.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetSorteio.Site.WebForm.Pages.Layout
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtSenha.Attributes["type"] = "password";
            }
        }

        protected void txtCEP_TextChanged(object sender, EventArgs e)
        {
            if (txtCEP.Text.Length == 8)
            {
                var ws = new WSCorreios.AtendeClienteClient();
                var resposta = ws.consultaCEP(txtCEP.Text);

                txtEndereco.Text = resposta.end + ", " + resposta.cidade + " - " + resposta.uf;
            }
            else
            {
                txtEndereco.Text = "";
            }
        }

        protected async void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();

            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;
            usuario.CEP = txtCEP.Text;
            usuario.DataCadastro = DateTime.Now;

            var message = JsonConvert.SerializeObject(usuario);

            using (var client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://localhost/DotNetSorteios.Servicos.WebAPI/api/Usuarios/InserirUsuario")
                {
                    Content = new StringContent(message, Encoding.UTF8, "application/json")
                };

               await client.SendAsync(request);
            }
            
        }
    }
}