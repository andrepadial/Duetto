using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleAcademia.Objetos
{
    public class Horario
    {
        public DateTime HorarioInicio { set; get; }

        public DateTime HorarioFim { set; get; }

        public string Status { set; get; }

        public List<Horario> Horarios { set; get; }


        public Horario()
        {            
        }

        
    }
}