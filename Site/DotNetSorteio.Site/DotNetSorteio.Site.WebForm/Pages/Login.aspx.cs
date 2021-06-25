using DotNetSorteio.Site.WebForm.Functions;
using DotNetSorteios.Servicos.Modelos;
using Newtonsoft.Json;
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
            try
            {
                Usuarios usuario = new Usuarios();
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;


                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("http://localhost/DotNetSorteios.Servicos.WebAPI/api/Login/RealizarLogin?email=" + usuario.Email + "&senha=" + usuario.Senha);
                    var IntegrationJsonString = await response.Content.ReadAsStringAsync();

                    usuario = JsonConvert.DeserializeObject<Usuarios>(IntegrationJsonString);
                }

                if (usuario.UsuarioId != 0)
                {
                    Session["Usuario"] = usuario;
                    //Session.Add("Usuario", usuario);

                    Response.Redirect("~/Pages/Home.aspx", false);
                }
                else
                {
                    //sem usuario
                }
            }
            catch (Exception)
            {

                throw;
            }           

        }
    }
}