using Best_Practices.Infraestructure.Factories;
using Best_Practices.Models;
using Best_Practices.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace Best_Practices.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // DIP: Dependemos de la abstracción IVehicleRepository, no de una clase concreta
        private readonly IVehicleRepository _repository;

        public HomeController(IVehicleRepository repository, ILogger<HomeController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            // SRP: El controlador solo prepara la vista, no calcula lógica de negocio
            var model = new HomeViewModel();
            model.Vehicles = _repository.GetAll().ToList();

            ViewBag.ErrorMessage = Request.Query.ContainsKey("error")
                ? Request.Query["error"].ToString()
                : null;

            return View(model);
        }

        // Factory Method: Delegamos la creación de objetos a clases Creator
        [HttpGet]
        public IActionResult AddMustang()
        {
            var creator = new FordMustangCreator();
            var vehicle = creator.Create();
            _repository.AddVehicle(vehicle);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult AddExplorer()
        {
            var creator = new FordExplorerCreator();
            var vehicle = creator.Create();
            _repository.AddVehicle(vehicle);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult AddEscape()
        {
            var creator = new FordEscapeCreator();
            var vehicle = creator.Create();
            _repository.AddVehicle(vehicle);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult StartEngine(Guid id)
        {
            try
            {
                var vehicle = _repository.Find(id);
                if (vehicle == null) return Redirect("/?error=Vehicle not found");
                
                vehicle.StartEngine();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return Redirect($"/?error={ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult AddGas(Guid id)
        {
            try
            {
                var vehicle = _repository.Find(id);
                if (vehicle == null) return Redirect("/?error=Vehicle not found");
                
                vehicle.AddGas();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return Redirect($"/?error={ex.Message}");
            }
        }

        [HttpGet]
        public IActionResult StopEngine(Guid id)
        {
            try
            {
                var vehicle = _repository.Find(id);
                if (vehicle == null) return Redirect("/?error=Vehicle not found");
                
                vehicle.StopEngine();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return Redirect($"/?error={ex.Message}");
            }
        }
    }
}