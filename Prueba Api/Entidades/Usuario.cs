using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Usuario
    {
        public int Id { set; get; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string? Nombre { set; get; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? Apellido { set; get; }
    }
}
