using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class FamiliaUsuario
    {
        public int IdFamiliaUsuario { get; set; }
        public int? IdFamilia { get; set; }
        public string Dvh { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Familia IdFamiliaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
