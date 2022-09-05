using SistemaClinica.Entities;

namespace SistemaClinica.Services.Interfaces
{
    public interface IPatientService
    {
        Task<Patient[]> GetPatientsAsync();
    }
}
