using DotNetSorteios.Servicos.WebAPI.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DotNetSorteios.Servicos.WebAPI.Controllers
{
    [RoutePrefix("api/Sorteio")]
    public class SorteioController : ApiController
    {
        [HttpGet]
        public DataTable ListarSorteios()
        {
            ServiceSorteio serviceSorteio = new ServiceSorteio();

            return serviceSorteio.ListarSorteios();                  
        }

    }
}
