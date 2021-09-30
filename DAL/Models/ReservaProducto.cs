using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ReservaProducto
    {
        public int IdReservaProducto { get; set; }
        public int? IdReserva { get; set; }
        public int? IdProducto { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
        public virtual Reserva IdReservaNavigation { get; set; }
    }
}
