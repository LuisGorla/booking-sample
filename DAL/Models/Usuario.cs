using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DAL.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Backups = new HashSet<Backup>();
            Bitacoras = new HashSet<Bitacora>();
            FamiliaUsuarios = new HashSet<FamiliaUsuario>();
            PatenteUsuarios = new HashSet<PatenteUsuario>();
            Reservas = new HashSet<Reserva>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string ContraseA { get; set; }
        public string Dni { get; set; }
        public string Contacto { get; set; }
        public string Dvh { get; set; }

        public virtual ICollection<Backup> Backups { get; set; }
        public virtual ICollection<Bitacora> Bitacoras { get; set; }
        public virtual ICollection<FamiliaUsuario> FamiliaUsuarios { get; set; }
        public virtual ICollection<PatenteUsuario> PatenteUsuarios { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
