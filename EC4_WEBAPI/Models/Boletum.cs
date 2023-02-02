using System;
using System.Collections.Generic;

#nullable disable

namespace EC4_WEBAPI.Models
{
    public partial class Boletum
    {
        public Boletum()
        {
            DetalleCompras = new HashSet<DetalleCompra>();
        }

        public int IdBoleta { get; set; }
        public double? Total { get; set; }
        public int? IdCliente { get; set; }
        public int? IdFuncion { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Funcion IdFuncionNavigation { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompras { get; set; }
    }
}
