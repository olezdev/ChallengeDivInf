using System.Text.Json.Serialization;

namespace SistemaClinica.Entities
{
    public class Patient : Person
    {
        public int HistoryClinic { get; set; }
        //public int Consultation { get; set; }

        //[JsonIgnore]
        public ICollection<Consultation>? Consultations { get; set; }
    }
}
