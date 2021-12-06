using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public partial class Traduccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTraduccion { get; set; }
        public string txtEspanio { get; set; }
        public string txtIngles  { get; set; }
        public string Formulario { get; set; }
    }
}
