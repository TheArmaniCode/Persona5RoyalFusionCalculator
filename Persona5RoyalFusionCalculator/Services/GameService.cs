using Persona5RoyalFusionCalculator.Data;
using Persona5RoyalFusionCalculator.Interfaces;
using Persona5RoyalFusionCalculator.Models;

namespace Persona5RoyalFusionCalculator.Services
{
    public class GameService : IGameService
    {
        private readonly PersonaDbContext _personaDbContext;
        public GameService(PersonaDbContext personaDbContext)
        {
            _personaDbContext = personaDbContext;
        }

        public List<GameModel> GetGames()
        {
            return _personaDbContext.Games.ToList();
        }

        public GameModel GetGameByID(int inGameID)
        {
            return _personaDbContext.Games.SingleOrDefault(g => g.ID == inGameID);
        }
    }
}
