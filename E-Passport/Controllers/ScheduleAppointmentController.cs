using Microsoft.AspNetCore.Mvc;
using E_Passport.Models;

namespace E_Passport.Controllers
{
    public class ScheduleAppointmentController : Controller
    {
        private readonly IScheduleAppointment _scheduleAppointmentRepository;

        public ScheduleAppointmentController(IScheduleAppointment scheduleAppointmentContext)
        {
            _scheduleAppointmentRepository = scheduleAppointmentContext;
        }
        public IActionResult Index()
        {
            var model = _scheduleAppointmentRepository.GetAllAppointments();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddAppointment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAppointment(ScheduleAppointment appointmentDetails)
        {
            if (ModelState.IsValid)
            {
                var newAppointment = _scheduleAppointmentRepository.Add(appointmentDetails);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
