using Microsoft.AspNetCore.Mvc;
using MVCTemplate.Models;

namespace MVCTemplate.Controllers
{
    public class ServicesController : Controller
    {
        private static readonly List<Service> Services = new List<Service>
        {
            new Service
            {
                Id = 1,
                Name = "Strzyżenie włosów",
                Description = "Kompleksowa usługa strzyżenia wraz z masażem oraz myciem głowy",
                IsAvailable = true,
                Duration = 40,
                Price = 100,
                    ImageFile = "strzyzenie.jpg"
            },
            new Service
            {
                Id = 2,
                Name = "Modelowanie włosów",
                Description = "Stylizacja i modelowanie włosów na specjalne okazje",
                IsAvailable = true,
                Duration = 60,
                Price = 150,
                    ImageFile = "strzyzenie.jpg"
            },
            new Service
            {
                Id = 3,
                Name = "Koloryzacja",
                Description = "Profesjonalna koloryzacja włosów z konsultacją stylisty",
                IsAvailable = false,
                Duration = 120,
                Price = 300,
                    ImageFile = "strzyzenie.jpg"
            },
            new Service
            {
                Id = 4,
                Name = "Keratynowe prostowanie włosów",
                Description = "Odbudowa i prostowanie włosów z użyciem keratyny",
                IsAvailable = true,
                Duration = 180,
                Price = 400,
                    ImageFile = "strzyzenie.jpg"
            },
            new Service
            {
                Id = 5,
                Name = "Pielęgnacja skóry głowy",
                Description = "Głębokie oczyszczanie i odżywianie skóry głowy",
                IsAvailable = true,
                Duration = 50,
                Price = 120,
                    ImageFile = "strzyzenie.jpg"
            },
            new Service
            {
                Id = 6,
                Name = "Przedłużanie włosów",
                Description = "Profesjonalne przedłużanie włosów z konsultacją stylisty",
                IsAvailable = false,
                Duration = 240,
                Price = 800,
                    ImageFile = "strzyzenie.jpg"
            },
            new Service
            {
                Id = 7,
                Name = "Strzyżenie dziecięce",
                Description = "Przyjazne i komfortowe strzyżenie dla najmłodszych",
                IsAvailable = true,
                Duration = 30,
                Price = 70,
                ImageFile = "strzyzenie.jpg"
            },
            new Service
            {
                Id = 8,
                Name = "Regeneracja włosów",
                Description = "Intensywna kuracja regenerująca włosy",
                IsAvailable = true,
                Duration = 90,
                Price = 250,
                ImageFile = "strzyzenie.jpg"  
            }
        };

        public IActionResult Overview()
        {
            return View(Services);
        }

        public IActionResult Details(int id)
        {
            var service = Services.FirstOrDefault(s => s.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }
    }
}
