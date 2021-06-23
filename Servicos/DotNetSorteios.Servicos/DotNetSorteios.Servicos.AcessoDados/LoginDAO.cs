using DotNetSorteios.Servicos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSorteios.Servicos.AcessoDados
{
    public class LoginDAO : DAO
    {
        public Usuarios RealizarLogin(string email, string senha)
        {
            string pesquisarUsuario = "SELECT * FROM Usuarios WHERE Email = '" + email + "' AND Senha = '" + senha + "'";
            
            return QuerySingle<Usuarios>(pesquisarUsuario);            
        }
    }
}
