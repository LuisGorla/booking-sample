using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Patente
    {
        public Patente()
        {
            PatenteFamilia = new HashSet<PatenteFamilium>();
            PatenteUsuarios = new HashSet<PatenteUsuario>();
        }

        public int IdPatente { get; set; }
        public string Detalle { get; set; }
        public string Dvh { get; set; }

        public virtual ICollection<PatenteFamilium> PatenteFamilia { get; set; }
        public virtual ICollection<PatenteUsuario> PatenteUsuarios { get; set; }
    }
}
