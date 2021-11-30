using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DAL.Models
{
    public partial class FamiliaUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFamiliaUsuario { get; set; }
        public int? IdFamilia { get; set; }
        public string Dvh { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Familia IdFamiliaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
