using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class OrdenProducto
    {
        public int IdOrdenProducto { get; set; }
        public int? IdOrden { get; set; }
        public int? IdProducto { get; set; }

        public virtual OrdenCompra IdOrdenNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
