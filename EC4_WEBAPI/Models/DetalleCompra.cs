using System;
using System.Collections.Generic;

#nullable disable

namespace EC4_WEBAPI.Models
{
    public partial class DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public int? IdBoleta { get; set; }
        public int? IdProducto { get; set; }
        public int? CantProducto { get; set; }
        public double? SubTotal { get; set; }

        public virtual Boletum IdBoletaNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
