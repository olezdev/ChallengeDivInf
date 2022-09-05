using SistemaClinica.Services.Interfaces;
using SistemaClinica.Entities;

namespace SistemaClinica.Services
{
    public class SeedDoctorService : IDoctorService
    {
        public Task<Doctor[]> GetDoctorsAsync()
        {
            var doc1 = new Doctor
            {
                DNI = 11222333,
                Name = "Marcelo",
                Matricula = 1223334,
                Specialty = "Pediatra"
            };

            var doc2 = new Doctor
            {
                DNI = 22333444,
                Name = "Marcelo",
                Matricula = 2233344,
                Specialty = "Oculista"
            };

            return Task.FromResult(new[] { doc1, doc2 });
        }
    }
}
