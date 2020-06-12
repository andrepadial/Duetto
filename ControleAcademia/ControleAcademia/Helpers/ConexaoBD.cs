using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ControleAcademia.Helpers
{
    public class ConexaoBD
    {

        public ConexaoBD()
        {

        }

        public static MySqlConnection getConexao()
        {
            //"Database=finder;Data Source=//online/find;Port=3306;User Id=test;Password=test";
            string conn = "Data Source=50.62.209.198;Database=Duetto;Port=3306;User ID=padial;password=#.h4ck3rp@d1al.#";
            MySqlConnection conexao = new MySqlConnection(conn);

            return conexao;
        }
    }
}