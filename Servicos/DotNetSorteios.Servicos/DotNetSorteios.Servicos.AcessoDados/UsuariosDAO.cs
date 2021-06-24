using DotNetSorteios.Servicos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSorteios.Servicos.AcessoDados
{
    public class UsuariosDAO : DAO
    {
        public bool InserirUsuario(Usuarios usuario)
        {
            try
            {
                string insert = "INSERT INTO Usuarios (Nome, Email, Senha, CEP, DataCadastro) VALUES (@Nome, @Email, @Senha, @CEP, @DataCadastro)";

                return Execute(insert, usuario); ;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public DataTable ListarUsuarios()
        {
            try
            {
                string select = "SELECT * FROM Usuarios" ;
                return ExecuteReader(select);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
