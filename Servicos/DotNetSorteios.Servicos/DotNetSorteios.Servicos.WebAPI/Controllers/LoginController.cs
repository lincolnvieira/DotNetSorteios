using DotNetSorteios.Servicos.Modelos;
using DotNetSorteios.Servicos.WebAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DotNetSorteios.Servicos.WebAPI.Controllers
{
    [RoutePrefix("api/Login")]
    public class LoginController : ApiController
    {
        [HttpGet]
        public IHttpActionResult RealizarLogin(string email, string senha)
        {
            ServiceLogin serviceLogin = new ServiceLogin();

            Usuarios usuario = serviceLogin.RealizarLogin(email, senha);

            if (usuario != null)
                return Ok(usuario);
            else
                return BadRequest();
        }
    }
}
