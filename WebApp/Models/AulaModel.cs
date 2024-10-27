using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class AulaModel
    {
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Materia { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Turma { get; set; }
    }
}
