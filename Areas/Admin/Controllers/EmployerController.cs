using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlumbersMVC.DataAccess;
using PlumbersMVC.Models;
using PlumbersMVC.ViewModels.Employer;
using System.Numerics;

namespace PlumbersMVC.Areas.Admin.Controllers
{
        [Area("Admin")]
    public class EmployerController(PlumberDbContext _context) : Controller
    {

        // GET: EmployerController
        public async Task<ActionResult> Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(EmployerCreateVM vm)
        {
            Employer employer = new Employer
            {
                Name = vm.Name,
                Surname = vm.Surname,
                PhoneNumber = vm.PhoneNumber,
                
            };

            await _context.Employers.AddAsync(employer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}