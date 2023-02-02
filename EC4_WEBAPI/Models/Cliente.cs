using System;
using System.Collections.Generic;

#nullable disable

namespace EC4_WEBAPI.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Boleta = new HashSet<Boletum>();
        }

        public int IdCliente { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Nombres { get; set; }
        public string Telefono { get; set; }

        public virtual ICollection<Boletum> Boleta { get; set; }
    }
}
