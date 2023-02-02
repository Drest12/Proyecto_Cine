using System;
using System.Collections.Generic;

#nullable disable

namespace EC4_WEBAPI.Models
{
    public partial class Sala
    {
        public Sala()
        {
            Funcions = new HashSet<Funcion>();
        }

        public int IdSala { get; set; }
        public int? NumSala { get; set; }
        public int Aforo { get; set; }
        public int? IdSede { get; set; }

        public virtual Sede IdSedeNavigation { get; set; }
        public virtual ICollection<Funcion> Funcions { get; set; }
    }
}
