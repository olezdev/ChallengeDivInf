using SistemaClinica.Entities;

namespace SistemaClinica.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClinicContext context)
        {
            if (context.Doctors.Any() && context.Patients.Any())
                return;

            #region Doctor
            var Marcelo = new Doctor
            {
                DNI = 11222333,
                Name = "Marcelo",
                Matricula = 1223334,
                Specialty = "Pediatra"
            };
            var Alberto = new Doctor
            {
                DNI = 22333444,
                Name = "Alberto",
                Matricula = 2233344,
                Specialty = "Oculista"
            };
            #endregion

            #region ConsultingRoom
            var guardia = new ConsultingRoom
            {
                Name = "Guardia"
            };

            var pediatria = new ConsultingRoom
            {
                Name = "Pediatria"
            };
            var oculista = new ConsultingRoom
            {
                Name = "Oculista"
            };
            #endregion

            #region ConsultingRoom
            var domicilio = new MedicalPractice
            {
                Description = "Visita a domicilio",
                MaterialCost = 1000
            };

            #endregion

            #region Consultas
            var consultaOculista = new Consultation
            {
                Description = "Atencion Oculista",
                Cost = 1000,
                Doctor = Alberto,
                ConsultingRoom = oculista,
                DateAttention = DateTime.Now,
                MedicalPractice = null,
            };
            var consultaPediatra = new Consultation
            {
                Description = "Atencion Pediatria",
                Cost = 1000,
                Doctor = Marcelo,
                ConsultingRoom = pediatria,
                DateAttention = DateTime.Now,
                MedicalPractice = null,
            };
            var visita = new Consultation
            {
                Description = "Visita a domicilio",
                Cost = 1000,
                Doctor = Marcelo,
                ConsultingRoom = null,
                DateAttention = DateTime.Now,
                MedicalPractice = domicilio,
            };

            #endregion


            #region Patient
            var patients = new Patient[]
            {
                new Patient
                {
                    DNI = 1122333,
                    Name = "Juan",
                    HistoryClinic = 1,
                    Consultations = new List<Consultation>
                    {
                        consultaPediatra
                    }
                },
                new Patient
                {
                    DNI = 33444555,
                    Name = "Pedro",
                    HistoryClinic = 1,
                    Consultations = new List<Consultation>
                    {
                        consultaOculista,
                        consultaPediatra
                    },
                    
                }
            };
            #endregion
            context.Patients.AddRange(patients);
            context.SaveChanges();
        }
    }
}
