using Persona5RoyalFusionCalculator.Models;

namespace Persona5RoyalFusionCalculator.Interfaces
{
    public interface IPersonaService
    {
        List<PersonaModel> GetPersonasByGame(int inGameID);
        PersonaModel GetPersonaByID(int inID);
        PersonaModel GetPersonaByName(string inName, int inGameID);
        FusionModel GetFusedPersona(int inPersona1, int inPersona2, int inPersona3);
        List<FusionModel> GetPersonaFusionCombos(int inPersonaID, int inGameID);
    }
}
