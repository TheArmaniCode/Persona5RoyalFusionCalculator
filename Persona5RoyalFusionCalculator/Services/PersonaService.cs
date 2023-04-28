using Persona5RoyalFusionCalculator.Data;
using Persona5RoyalFusionCalculator.Interfaces;
using Persona5RoyalFusionCalculator.Models;

namespace Persona5RoyalFusionCalculator.Services
{
    public class PersonaService : IPersonaService
    {
        private readonly PersonaDbContext _personaDbContext;
        public PersonaService(PersonaDbContext personaDbContext)
        {
            _personaDbContext = personaDbContext;
        }

        public List<PersonaModel> GetPersonasByGame(int inGameID)
        {
            return _personaDbContext.Personas.Where(p => p.GameID == inGameID).ToList();
        }

        public PersonaModel GetPersonaByID(int inID)
        {
            return _personaDbContext.Personas.FirstOrDefault(p => p.Id == inID);
        }

        public PersonaModel GetPersonaByName(string inName, int inGameID)
        {
            return _personaDbContext.Personas.FirstOrDefault(p => p.Name == inName && p.GameID == inGameID);
        }

        public FusionModel GetFusedPersona(int inPersona1, int inPersona2, int inPersona3)
        {
            var query = from f in _personaDbContext.Fusions
                        join p in _personaDbContext.Personas on f.Result equals p.Id
                        where (f.Persona1 == inPersona1 || f.Persona1 == inPersona2)
                        && (f.Persona2 == inPersona1 || f.Persona2 == inPersona2)
                        select new FusionModel
                        {
                            Persona1 = f.Persona1,
                            Persona2 = f.Persona2,
                            Result = f.Result
                        };

            var personas = query.ToList();

            if(inPersona3 != null)
            {
                personas = personas.Where(p => p.Persona3 == inPersona3).ToList();
            }
            
            return personas.First();
        }

        public List<FusionModel> GetPersonaFusionCombos(int inPersonaID, int inGameID)
        {
            return _personaDbContext.Fusions.Where(f => f.Result == inPersonaID && f.GameID == inGameID).ToList();
        }
    }
}
