using Microsoft.EntityFrameworkCore;
using SistemaClinica.Data;
using SistemaClinica.Entities;
using SistemaClinica.Services.Interfaces;

namespace SistemaClinica.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly ClinicContext _context;

        public DoctorService(ClinicContext context)
        {
            _context = context;
        }

        public async Task<Doctor[]> GetDoctorsAsync()
        {
            return await _context.Doctors
                .ToArrayAsync();
        }
    }
}
