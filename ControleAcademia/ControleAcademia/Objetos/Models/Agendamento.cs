using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleAcademia.Objetos.Models
{
    public class Agendamento
    {
        public int? Id { set; get; }
        public DateTime? DataAgendamento { set; get; }
        public int? Apto { set; get; }
        public TimeSpan? HorarioInicial { set; get; }
        public TimeSpan? HorarioFinal { set; get; }
        public string Status { set; get; }
    }
}