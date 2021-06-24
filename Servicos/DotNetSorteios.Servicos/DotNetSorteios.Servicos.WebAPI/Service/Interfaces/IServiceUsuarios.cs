using DotNetSorteios.Servicos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace DotNetSorteios.Servicos.WebAPI.Service.Interfaces
{
    public interface IServiceUsuarios
    {
        bool InserirUsuario(Usuarios usuario);

        DataTable ListarUsuarios();
    }
}