using SistemaClinica.Entities;

namespace SistemaClinica.Services.Interfaces
{
    public interface IDoctorService
    {
        Task<Doctor[]> GetDoctorsAsync();
    }
}
