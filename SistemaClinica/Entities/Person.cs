using System.ComponentModel.DataAnnotations;

namespace SistemaClinica.Entities
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public int DNI { get; set; }

        public string? Name { get; set; }
    }
}
