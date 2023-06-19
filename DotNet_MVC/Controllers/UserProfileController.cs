using Dotnet_Mvc.Data;
using Dotnet_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
namespace Dotnet_Mvc.Controllers{
    public class UserProfileController:Controller
    {

        private readonly ApplicationDbContext _db;
        public UserProfileController(ApplicationDbContext db)
        {
                _db = db;
        }
        public IActionResult Index()
        {
          //  var userProfile = _db.UserProfile.ToList();
          List<UserProfile> users = _db.UserProfile.ToList();
            return View(users);
        }
    }
}
