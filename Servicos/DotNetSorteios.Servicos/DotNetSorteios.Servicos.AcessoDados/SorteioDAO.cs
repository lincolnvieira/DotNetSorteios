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
        public DataTable ListarSorteios(int usuarioId)
        {
            string pesquisar = @"SELECT Sorteios.SorteioId, Titulo, Sorteios.Descricao, SituacoesSorteio.Descricao as Situacao, convert(date,DataInicio) as DataInicio , convert(date,DataFim) as DataFim, ParticipantesSorteio.UsuarioId 
                                 FROM Sorteios
                                 LEFT JOIN SituacoesSorteio ON SituacoesSorteio.SituacaoSorteioId = Sorteios.SituacaoSorteioId
                                 LEFT JOIN ParticipantesSorteio ON ParticipantesSorteio.SorteioId = Sorteios.SorteioId AND (ParticipantesSorteio.UsuarioId = " + usuarioId + " OR ParticipantesSorteio.UsuarioId IS NULL)";
            
            DataTable dt = ExecuteReader(pesquisar);
            return dt;
        }
    }
}
