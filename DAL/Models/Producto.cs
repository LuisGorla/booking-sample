using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Producto
    {
        public Producto()
        {
            OrdenProductos = new HashSet<OrdenProducto>();
            ReservaProductos = new HashSet<ReservaProducto>();
        }

        public int IdProducto { get; set; }
        public int? Cantidad { get; set; }
        public string TipoProducto { get; set; }
        public decimal? Valor { get; set; }

        public virtual ICollection<OrdenProducto> OrdenProductos { get; set; }
        public virtual ICollection<ReservaProducto> ReservaProductos { get; set; }
    }
}
