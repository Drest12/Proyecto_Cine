using System;
using System.Collections.Generic;

#nullable disable

namespace EC4_WEBAPI.Models
{
    public partial class Funcion
    {
        public Funcion()
        {
            Boleta = new HashSet<Boletum>();
            Empleados = new HashSet<Empleado>();
        }

        public int IdFuncion { get; set; }
        public string HoraFuncion { get; set; }
        public DateTime? FechaFuncion { get; set; }
        public int? IdSala { get; set; }
        public int? IdPelicula { get; set; }

        public virtual Pelicula IdPeliculaNavigation { get; set; }
        public virtual Sala IdSalaNavigation { get; set; }
        public virtual ICollection<Boletum> Boleta { get; set; }
        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
