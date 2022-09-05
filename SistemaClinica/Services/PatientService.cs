using Microsoft.EntityFrameworkCore;
using SistemaClinica.Data;
using SistemaClinica.Entities;
using SistemaClinica.Services.Interfaces;

namespace SistemaClinica.Services
{
    public class PatientService : IPatientService
    {
        private readonly ClinicContext _context;

        public PatientService(ClinicContext context)
        {
            _context = context;
        }

        public async Task<Patient[]> GetPatientsAsync()
        {
            return await _context.Patients
                .Include(p => p.Consultations)
                .ToArrayAsync();
        }
    }
}
