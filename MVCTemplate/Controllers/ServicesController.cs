using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCTemplate.Data;
using MVCTemplate.Models;
using System.Threading.Tasks;

namespace MVCTemplate.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ServiceContext _context;

        public ServicesController(ServiceContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Overview()
        {
            var services = await _context.Services.ToListAsync();
            return View(services);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AdminOverview()
        {
            var services = await _context.Services.ToListAsync();
            return View(services);
        }

        public async Task<IActionResult> Details(int id)
        {
            var service = await _context.Services.FirstOrDefaultAsync(s => s.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }



        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create(Service service)
        {
            if (ModelState.IsValid)
            {
                _context.Services.Add(service);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Overview));
            }
            return View(service);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }
            return View(service);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Edit(Service service)
        {
            if (ModelState.IsValid)
            {
                _context.Services.Update(service);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Overview));
            }
            return View(service);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }
            return View(service);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service != null)
            {
                _context.Services.Remove(service);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Overview));
        }
    }
}


