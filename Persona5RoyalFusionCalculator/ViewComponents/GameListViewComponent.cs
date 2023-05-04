using Microsoft.AspNetCore.Mvc;
using Persona5RoyalFusionCalculator.Interfaces;

namespace Persona5RoyalFusionCalculator.ViewComponents
{
    public class GameListViewComponent : ViewComponent
    {
        private readonly IGameService _gameService;

        public GameListViewComponent(IGameService gameService)
        {
            _gameService = gameService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var gameList = _gameService.GetGames();

            return View(gameList);
        }
    }
}
