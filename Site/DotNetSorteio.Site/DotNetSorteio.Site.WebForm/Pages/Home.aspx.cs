using DotNetSorteios.Servicos.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetSorteio.Site.WebForm.Pages
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregaRepeater();
            }
        }

        private async void CarregaRepeater()
        {
            try
            {
                Usuarios usuario = (Usuarios)Session["Usuario"];

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("http://localhost/DotNetSorteios.Servicos.WebAPI/api/Sorteio/ListarSorteios?usuarioId=" + usuario.UsuarioId);
                    var IntegrationJsonString = await response.Content.ReadAsStringAsync();

                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(IntegrationJsonString, (typeof(DataTable)));                    

                    gridSoteio.DataSource = dt;
                    gridSoteio.DataBind();
                }                                
            }
            catch (Exception ex)
            {
                
            }

        }

        protected void gridSoteio_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if(e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                RepeaterItem item = e.Item;

                string usuarioId = (item.FindControl("hdfUsuarioId") as HiddenField).Value;

                if(string.IsNullOrEmpty(usuarioId))
                {
                    (item.FindControl("btnParticipar") as Button).Visible = true;
                }
                else
                {
                    (item.FindControl("btnDeixar") as Button).Visible = true;
                }
            }
        }
    }
}