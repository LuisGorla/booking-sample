using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Sala
    {
        public Sala()
        {
            OrdenCompras = new HashSet<OrdenCompra>();
            Reservas = new HashSet<Reserva>();
        }

        public int IdSala { get; set; }
        public int? Capacidad { get; set; }

        public virtual ICollection<OrdenCompra> OrdenCompras { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
