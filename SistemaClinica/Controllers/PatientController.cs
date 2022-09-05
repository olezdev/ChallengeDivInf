using Microsoft.AspNetCore.Mvc;
using SistemaClinica.Models;
using SistemaClinica.Services.Interfaces;

namespace SistemaClinica.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        // GET: PatientController
        public async Task<IActionResult> IndexAsync()
        {
            var patients = await _patientService.GetPatientsAsync();
            var model = new PatientViewModel()
            {
                Patients = patients
            };

            return View(model);
        }
    }
}
