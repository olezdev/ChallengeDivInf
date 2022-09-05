using System.Text.Json.Serialization;

namespace SistemaClinica.Entities
{
    public class Consultation
    {
        public int Id { get; set; }
        public DateTime DateAttention { get; set; }
        public int Cost { get; set; }
        public string? Description { get; set; }
        public Doctor? Doctor { get; set; }
        [JsonIgnore]
        public ICollection<Patient>? Patients { get; set; }
        public ConsultingRoom? ConsultingRoom { get; set; }
        public MedicalPractice? MedicalPractice { get; set; }
    }
}
