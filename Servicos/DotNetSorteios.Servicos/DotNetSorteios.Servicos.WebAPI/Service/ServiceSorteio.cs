using DotNetSorteios.Servicos.AcessoDados;
using DotNetSorteios.Servicos.WebAPI.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DotNetSorteios.Servicos.WebAPI.Service
{
    public class ServiceSorteio : IServiceSorteio
    {
        public DataTable ListarSorteios()
        {
            SorteioDAO sorteioDAO = new SorteioDAO();

            return sorteioDAO.ListarSorteios();
        }
    }
}