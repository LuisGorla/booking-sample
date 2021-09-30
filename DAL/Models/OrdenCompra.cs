using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class OrdenCompra
    {
        public OrdenCompra()
        {
            OrdenProductos = new HashSet<OrdenProducto>();
            Reservas = new HashSet<Reserva>();
        }

        public int IdOrden { get; set; }
        public bool? Aprobada { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Total { get; set; }
        public int? IdSala { get; set; }
        public string Dvh { get; set; }

        public virtual Sala IdSalaNavigation { get; set; }
        public virtual ICollection<OrdenProducto> OrdenProductos { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
