using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DAL.Models
{
    public partial class Familia
    {
        public Familia()
        {
            FamiliaUsuarios = new HashSet<FamiliaUsuario>();
            PatenteFamilia = new HashSet<PatenteFamilium>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFamilia { get; set; }
        public string Detalle { get; set; }
        public string Dvh { get; set; }

        public virtual ICollection<FamiliaUsuario> FamiliaUsuarios { get; set; }
        public virtual ICollection<PatenteFamilium> PatenteFamilia { get; set; }
    }
}
