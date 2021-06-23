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
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("https://localhost:44371/api/Sorteio/ListarSorteios");
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
    }
}