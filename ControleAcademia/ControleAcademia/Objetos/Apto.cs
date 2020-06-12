using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleAcademia.Objetos
{
    public class Apto
    {
        public string Numero { set; get; }

        public Apto()
        {

        }

        public static List<Apto> retornaAptos()
        {
            List<Apto> aptos = new List<Apto>();

            for (int i = 1; i <= 1999; i++)
            {
                Apto a = new Apto();
                a.Numero = i.ToString();
                aptos.Add(a);
            }

            return aptos;
        }
    }
}