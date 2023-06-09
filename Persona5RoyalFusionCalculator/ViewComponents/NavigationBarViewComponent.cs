﻿using Microsoft.AspNetCore.Mvc;
using Persona5RoyalFusionCalculator.Interfaces;

namespace Persona5RoyalFusionCalculator.ViewComponents
{
    public class NavigationBarViewComponent : ViewComponent
    {
        private readonly IGameService _gameService;

        public NavigationBarViewComponent(IGameService gameService)
        {
            _gameService = gameService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var games = _gameService.GetGames();

            return View(games);
        }
    }
}
