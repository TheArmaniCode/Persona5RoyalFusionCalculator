﻿using Persona5RoyalFusionCalculator.Data;
using Persona5RoyalFusionCalculator.Interfaces;
using Persona5RoyalFusionCalculator.Models;

namespace Persona5RoyalFusionCalculator.Services
{
    public class FusionService : IFusionService
    {
        private readonly PersonaDbContext _personaDbContext;
        public FusionService(PersonaDbContext personaDbContext)
        {
            _personaDbContext = personaDbContext;
        }

        public void AddFusion(int inPersona1, int inPersona2, int inResult, int inGameID, int inPersona3 = 0)
        {
            var fusion = new FusionModel();

            fusion.Persona1 = inPersona1;
            fusion.Persona2 = inPersona2;
            if(inPersona3 != 0) fusion.Persona3 = inPersona3;
            fusion.Result = inResult;
            fusion.GameID = inGameID;

            _personaDbContext.Fusions.Add(fusion);
            _personaDbContext.SaveChanges();
        }
    }
}
