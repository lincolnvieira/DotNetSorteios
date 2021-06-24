using DotNetSorteios.Servicos.AcessoDados;
using DotNetSorteios.Servicos.Modelos;
using DotNetSorteios.Servicos.WebAPI.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DotNetSorteios.Servicos.WebAPI.Service
{
    public class ServiceUsuarios : IServiceUsuarios
    {            
        public bool InserirUsuario(Usuarios usuario)
        {
            UsuariosDAO usuarioDAO = new UsuariosDAO();
            
            usuarioDAO.InserirUsuario(usuario);

            return true;
        }

        public DataTable ListarUsuarios()
        {
            UsuariosDAO usuarioDAO = new UsuariosDAO();

            return usuarioDAO.ListarUsuarios(); ;
        }
    }
}