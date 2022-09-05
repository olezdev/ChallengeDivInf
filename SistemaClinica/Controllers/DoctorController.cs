using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaClinica.Models;
using SistemaClinica.Services.Interfaces;

namespace SistemaClinica.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        // GET: DoctorController
        public async Task<IActionResult> IndexAsync()
        {
            var doctors = await _doctorService.GetDoctorsAsync();
            var model = new DoctorViewModel()
            {
                Doctors = doctors
            };

            return View(model);
        }
    }
}
