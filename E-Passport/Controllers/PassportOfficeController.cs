using Microsoft.AspNetCore.Mvc;
using E_Passport.Models;
using System.Diagnostics;

namespace E_Passport.Controllers
{
    public class PassportOfficeController : Controller
    {
        private readonly IPassportOffice _passportRepository;

        public PassportOfficeController(IPassportOffice passportOfficeContext)
        {
            _passportRepository = passportOfficeContext;
        }
        public IActionResult Index()
        {
            var model = _passportRepository.GetAllOfficeDetails();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddOffice()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddOffice(PassportOffice passportOffice)
        {
            if (ModelState.IsValid)
            {
                PassportOffice newOffice = _passportRepository.Add(passportOffice);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
