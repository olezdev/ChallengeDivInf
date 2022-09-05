using Microsoft.EntityFrameworkCore;
using SistemaClinica.Entities;

namespace SistemaClinica.Data
{
    public class ClinicContext : DbContext
    {
        public ClinicContext(DbContextOptions<ClinicContext> options)
                : base(options)
        {
        }

        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<Consultation> Consultations => Set<Consultation>();
        public DbSet<ConsultingRoom> ConsultingRooms => Set<ConsultingRoom>();
        public DbSet<MedicalPractice> MedicalPractices => Set<MedicalPractice>();
    }
}
