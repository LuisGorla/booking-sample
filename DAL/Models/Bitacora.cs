using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DAL.Models
{
    public partial class Bitacora
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdBicatora { get; set; }
        public int? Criticidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Operacion { get; set; }
        public int? IdUsuario { get; set; }
        public string Dvh { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
