using DotNetSorteios.Servicos.AcessoDados;
using DotNetSorteios.Servicos.Modelos;
using DotNetSorteios.Servicos.WebAPI.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetSorteios.Servicos.WebAPI.Service
{
    public class ServiceLogin : IServiceLogin
    {
        public Usuarios RealizarLogin(string email, string senha)
        {
            LoginDAO loginDAO = new LoginDAO();

            return loginDAO.RealizarLogin(email, senha);           
        }
    }
}