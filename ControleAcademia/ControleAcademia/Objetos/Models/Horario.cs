using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleAcademia.Objetos.Models
{
    public class Horario
    {
        public int Id { set; get; }
        public Time HorarioInicial { set; get; }
        public Time HorarioFinal { set; get; }

    }
}
