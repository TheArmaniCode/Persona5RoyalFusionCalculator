using Microsoft.Office.Interop.Excel;
using ClosedXML.Excel;
using Persona5RoyalFusionCalculator.Data;
using Persona5RoyalFusionCalculator.Interfaces;

namespace Persona5RoyalFusionCalculator.Services
{
    public class ImportService : IImportService
    {
        private readonly PersonaDbContext _personaDbContext;
        public IPersonaService _personaService;
        public IFusionService _fusionService;

        public ImportService(PersonaDbContext personaDbContext, IPersonaService personaService, IFusionService fusionService)
        {
            _personaDbContext = personaDbContext;
            _personaService = personaService;
            _fusionService = fusionService;
        }

        public void ImportFusions(IFormFile inFile, int inGameID)
        {
            Application excel = new Application();
            var wb =  new XLWorkbook(inFile.OpenReadStream());
            var ws = wb.Worksheet(1);
            var r = 1;
            string cellValue;
            int persona1 = 0, persona2 = 0, persona3 = 0, result = 0;
            var last = ws.Cells().LastOrDefault();

            foreach(var cell in ws.Cells())
            {
                cellValue = cell.GetValue<string>();
                if (cellValue != "")
                {
                    if (inGameID == 2)
                    {
                        switch (r % 4)
                        {
                            case 1:
                                persona1 = _personaService.GetPersonaByName(cellValue, inGameID).Id;
                                break;
                            case 2:
                                persona2 = _personaService.GetPersonaByName(cellValue, inGameID).Id;
                                break;
                            case 3:
                                persona3 = _personaService.GetPersonaByName(cellValue, inGameID).Id;
                                break;
                            case 0:
                                result = _personaService.GetPersonaByName(cellValue, inGameID).Id;
                                break;
                        }
                    }

                    else if (inGameID == 3)
                    {
                        switch (r % 3)
                        {
                            case 1:
                                persona1 = _personaService.GetPersonaByName(cellValue, inGameID).Id;
                                break;
                            case 2:
                                persona2 = _personaService.GetPersonaByName(cellValue, inGameID).Id;
                                break;
                            case 0:
                                result = _personaService.GetPersonaByName(cellValue, inGameID).Id;
                                break;
                        }

                        _fusionService.AddFusion(persona1, persona2, result, inGameID);
                    }

                    r++;
                }
            }
        }

    }
}
