using Microsoft.Office.Interop.Excel;
using Microsoft.AspNetCore.Mvc;
using Persona5RoyalFusionCalculator.Interfaces;
using Grpc.Core;

namespace Persona5RoyalFusionCalculator.Controllers
{
    public class ImportFusionsController : Controller
    {
        private readonly ILogger<ImportFusionsController> _logger;
        private readonly IImportService _importService;

        public ImportFusionsController(ILogger<ImportFusionsController> logger, IImportService importService)
        {
            _logger = logger;
            _importService = importService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormFile inPersonasFile, int inGameID)
        {
            try
            {
                if (inPersonasFile.Length > 0)
                {
                    _importService.ImportFusions(inPersonasFile, inGameID);
                }
                ViewBag.Message = "File Uploaded Successfully!!";
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Upload failed";
                return View();
            }
        }
    }
}
