using Ecommerece_dotnet.Data;
using Ecommerece_dotnet.Data.Services;
using Ecommerece_dotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerece_dotnet.Controllers
{
    public class ActorsController : Controller
    {
        private IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        { 
            var data = await _service.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")]Actor actor)
        {
            /*if(!ModelState.IsValid)
            {
                return View(actor);
            }*/
            _service.Add(actor);

            return RedirectToAction(nameof(Index));
        }
        
    }
}
