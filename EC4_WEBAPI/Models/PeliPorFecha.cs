using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EC4_WEBAPI.Models
{
    public class PeliPorFecha
    {
        [Key]

        public int id_pelicula { get; set; }
        public string nom_pelicula { get; set; }
        public string sipnosis { get; set; }
        public string genero { get; set; }
        public string fecha_estreno { get; set; }
        public string duracion_horas { get; set; }
        public string clasificacion { get; set; }
    }
}
