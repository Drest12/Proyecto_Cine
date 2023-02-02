using System;
using System.Collections.Generic;

#nullable disable

namespace EC4_WEBAPI.Models
{
    public partial class Sede
    {
        public Sede()
        {
            Salas = new HashSet<Sala>();
        }

        public int IdSede { get; set; }
        public string NomSede { get; set; }

        public virtual ICollection<Sala> Salas { get; set; }
    }
}
