using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DAL.Models
{
    public partial class PatenteUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPatenteUsuario { get; set; }
        public int IdUsuario { get; set; }
        public string Dvh { get; set; }
        public int IdPatente { get; set; }

        public virtual Patente IdPatenteNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
