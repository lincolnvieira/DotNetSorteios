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
    [RoutePrefix("api/usuarios")]
    public class UsuariosController : ApiController
    {        
        public IHttpActionResult InserirUsuario([FromBody] Usuarios usuario)
        {
            ServiceUsuarios serviceUsuario = new ServiceUsuarios();
            
            serviceUsuario.InserirUsuario(usuario);                        
            
            return Ok();
        }      
    }
}
