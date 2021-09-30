using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Backup
    {
        public int IdBackup { get; set; }
        public string Directorio { get; set; }
        public DateTime? Fecha { get; set; }
        public string Usuario { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
