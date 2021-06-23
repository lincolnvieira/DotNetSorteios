using DotNetSorteios.Servicos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSorteios.Servicos.AcessoDados
{
    public class UsuariosDAO : DAO
    {
        public Usuarios InserirUsuario(Usuarios usuario)
        {
            string insert = "INSERT INTO Usuarios (Nome, Email, Senha, CEP, DataCadastro) VALUES (@Nome, @Email, @Senha, @CEP, @DataCadastro)";

            return QuerySingle<Usuarios>(insert, usuario);
        }        
    }
}
