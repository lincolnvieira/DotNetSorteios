using DotNetSorteios.Servicos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetSorteios.Servicos.WebAPI.Service.Interfaces
{
    public interface IServiceLogin
    {
        Usuarios RealizarLogin(string email, string senha);
    }
}