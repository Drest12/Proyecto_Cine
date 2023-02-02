using System;
using System.Collections.Generic;

#nullable disable

namespace EC4_WEBAPI.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleCompras = new HashSet<DetalleCompra>();
        }

        public int IdProducto { get; set; }
        public string NomProducto { get; set; }
        public string DesProducto { get; set; }
        public double? PreProducto { get; set; }
        public int? StoProducto { get; set; }

        public virtual ICollection<DetalleCompra> DetalleCompras { get; set; }
    }
}
