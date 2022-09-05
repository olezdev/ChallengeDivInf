using System.ComponentModel.DataAnnotations;

namespace SistemaClinica.Entities
{
    public class Doctor : Person
    {
        [Required]
        public int Matricula { get; set; }

        [Required]
        public string? Specialty { get; set; }
    }
}
