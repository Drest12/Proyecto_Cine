using System;
using System.Collections.Generic;

#nullable disable

namespace EC4_WEBAPI.Models
{
    public partial class Empleado
    {
        public int IdEmpleados { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nombres { get; set; }
        public string Telefono { get; set; }
        public string Turno { get; set; }
        public int? IdFuncion { get; set; }

        public virtual Funcion IdFuncionNavigation { get; set; }
    }
}
