using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ControleAcademia.Objetos.Models;
using Dapper;
using Dapper.Contrib;
using MySql.Data;

namespace ControleAcademia.Objetos.DataAccess
{
    public class AptoDao
    {
        

        public static List<Apto> GetApartamentos()
        {
            List<Apto> apartamentos = new List<Apto>();

            using (var conexao = Helpers.ConexaoBD.getConexao())
            {
                string comando = "SELECT Id, Numero FROM Apto ORDER BY Id ASC";

                apartamentos = conexao.Query<Apto>(comando).ToList();
            }

            return apartamentos;
        }
    }
}