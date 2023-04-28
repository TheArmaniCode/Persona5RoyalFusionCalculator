using Microsoft.AspNetCore.Mvc;
using Persona5RoyalFusionCalculator.Interfaces;

namespace Persona5RoyalFusionCalculator.Controllers
{
    public class Persona5Controller : Controller
    {
        private readonly ILogger<Persona5Controller> _logger;
        private readonly IImportService _importService;

        public Persona5Controller(ILogger<Persona5Controller> logger, IImportService importService)
        {
            _logger = logger;
            _importService = importService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
