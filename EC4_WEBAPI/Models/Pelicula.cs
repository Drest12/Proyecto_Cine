using System;
using System.Collections.Generic;

#nullable disable

namespace EC4_WEBAPI.Models
{
    public partial class Pelicula
    {
        public Pelicula()
        {
            Funcions = new HashSet<Funcion>();
        }

        public int IdPelicula { get; set; }
        public string NomPelicula { get; set; }
        public string Sipnosis { get; set; }
        public string Genero { get; set; }
        public string FechaEstreno { get; set; }
        public string DuracionHoras { get; set; }
        public string Clasificacion { get; set; }

        public virtual ICollection<Funcion> Funcions { get; set; }
    }
}
