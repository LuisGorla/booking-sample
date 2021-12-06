using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public partial class UserIdioma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUserIdioma { get; set; }
        public int IdUser { get; set; }
        public int IdIdioma { get; set; }
    }
}
