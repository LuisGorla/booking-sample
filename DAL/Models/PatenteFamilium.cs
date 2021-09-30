using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PatenteFamilium
    {
        public int IdPatenteFamilia { get; set; }
        public int? IdPatente { get; set; }
        public string Dvh { get; set; }
        public int? IdFamilia { get; set; }

        public virtual Familia IdFamiliaNavigation { get; set; }
        public virtual Patente IdPatenteNavigation { get; set; }
    }
}
