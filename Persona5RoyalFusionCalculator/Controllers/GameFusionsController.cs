using Microsoft.AspNetCore.Mvc;
using Persona5RoyalFusionCalculator.Interfaces;

namespace Persona5RoyalFusionCalculator.Controllers
{
    public class GameFusionsController : Controller
    {
        private readonly ILogger<GameFusionsController> _logger;
        private readonly IGameService _gameService;
        private readonly IImportService _importService;

        public GameFusionsController(ILogger<GameFusionsController> logger, IGameService gameService, IImportService importService)
        {
            _logger = logger;
            _importService = importService;
            _gameService = gameService;
        }

        public IActionResult Index(int inGameID)
        {
            var game = _gameService.GetGameByID(inGameID);

            return View(game);
        }
    }
}
