using Microsoft.AspNetCore.Mvc;

namespace Persona5RoyalFusionCalculator.Controllers
{
    public class Persona4Controller : Controller
    {
        private readonly ILogger<Persona4Controller> _logger;

        public Persona4Controller(ILogger<Persona4Controller> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
