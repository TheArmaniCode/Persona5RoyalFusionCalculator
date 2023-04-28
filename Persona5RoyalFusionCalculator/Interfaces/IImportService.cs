using Microsoft.Office.Interop.Excel;

namespace Persona5RoyalFusionCalculator.Interfaces
{
    public interface IImportService
    { 
        void ImportFusions(IFormFile inFile, int inGameID);
    }
}
