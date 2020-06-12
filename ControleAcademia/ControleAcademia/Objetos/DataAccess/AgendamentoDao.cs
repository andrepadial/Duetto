using ControleAcademia.Objetos.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ControleAcademia.Objetos.DataAccess
{
    public class AgendamentoDao
    {
        public static List<Agendamento> GetAgendamentos(DateTime dataBase)
        {
            List<Agendamento> agendamentos = new List<Agendamento>();

            var data = dataBase.ToString("yyyy-MM-dd");

            string comando = "SELECT A.Id, CAST('" + data + "' AS DATETIME) AS DataAgendamento, ";
            comando += " AP.Numero AS Apto, H.HorarioInicial, H.HorarioFinal, (CASE WHEN A.Id IS NULL THEN 'Disponível' ELSE 'Indisponível' END) AS Status";
            comando += " FROM Horario H LEFT OUTER JOIN Agendamento A ON A.IdHorario ";
            comando += " LEFT OUTER JOIN Apto AP ON A.IdApto = AP.Id AND A.DataAgendamento = '" + data + "' ";

            using (var conexao = Helpers.ConexaoBD.getConexao())
            {                
                agendamentos = conexao.Query<Agendamento>(comando).ToList();
            }

            return agendamentos;
        }
    }
}