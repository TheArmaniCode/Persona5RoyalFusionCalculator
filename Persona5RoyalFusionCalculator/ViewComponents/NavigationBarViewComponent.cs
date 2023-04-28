using Microsoft.AspNetCore.Mvc;

namespace Persona5RoyalFusionCalculator.ViewComponents
{
    public class NavigationBarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
