using DotNetSorteio.Site.WebForm.Functions;
using DotNetSorteios.Servicos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetSorteio.Site.WebForm.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtSenha.Attributes["type"] = "password";
            }
        }
      

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Cadastro.aspx");
        }

        protected async void btnLogin_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;
            

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:44371/api/Login/RealizarLogin?email=" + usuario.Email + "&senha=" + usuario.Senha);
                await response.Content.ReadAsStringAsync();
            }

        }
    }
}