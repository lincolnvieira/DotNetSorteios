using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSorteios.Servicos.AcessoDados
{
    public class SorteioDAO : DAO
    {
        public DataTable ListarSorteios()
        {
            //string pesquisar = "SELECT * FROM Sorteios";
            //var v = QuerySingle<DataTable>(pesquisar);
            //return v;

            DataTable dt = new DataTable();
            return dt;
        }
    }
}
