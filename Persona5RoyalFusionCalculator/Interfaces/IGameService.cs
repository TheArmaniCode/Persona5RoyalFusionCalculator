using Persona5RoyalFusionCalculator.Models;

namespace Persona5RoyalFusionCalculator.Interfaces
{
    public interface IGameService
    {
        public List<GameModel> GetGames();
        GameModel GetGameByID(int inGameID);
    }
}
