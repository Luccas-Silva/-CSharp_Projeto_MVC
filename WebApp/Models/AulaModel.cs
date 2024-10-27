using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("tb_aula")]
    public class AulaModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        public required string Materia { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        public required string Turma { get; set; }
    }
}
