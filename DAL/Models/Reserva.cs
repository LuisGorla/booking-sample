using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Reserva
    {
        public Reserva()
        {
            ReservaProductos = new HashSet<ReservaProducto>();
        }

        public int IdReserva { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdOrden { get; set; }
        public int? IdSala { get; set; }
        public string Dvh { get; set; }

        public virtual OrdenCompra IdOrdenNavigation { get; set; }
        public virtual Sala IdSalaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<ReservaProducto> ReservaProductos { get; set; }
    }
}
