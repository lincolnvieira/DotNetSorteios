using DotNetSorteios.Servicos.Modelos;
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
    [RoutePrefix("api/usuarios")]
    public class UsuariosController : ApiController
    {   
        [HttpPost]
        public IHttpActionResult InserirUsuario([FromBody] Usuarios usuario)
        {
            ServiceUsuarios serviceUsuario = new ServiceUsuarios();

            try
            {
                serviceUsuario.InserirUsuario(usuario);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("Erro ao inserir usuario");
            }
        }
        
        [HttpGet]
        public IHttpActionResult ListarUsuarios()
        {
            DataTable datatable = new DataTable();
            ServiceUsuarios serviceUsuario = new ServiceUsuarios();

            datatable = serviceUsuario.ListarUsuarios();
            return Ok(datatable);
        }
    }
}
