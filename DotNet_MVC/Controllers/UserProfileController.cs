using Microsoft.AspNetCore.Mvc;
namespace Dotnet_Mvc.Controllers{
    public class UserProfileController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
