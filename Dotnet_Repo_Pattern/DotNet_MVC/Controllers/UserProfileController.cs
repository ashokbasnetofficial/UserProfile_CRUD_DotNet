using Dotnet_Mvc.DataAccess.Data;
using DotNet_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_Mvc.Controllers
{
    public class UserProfileController : Controller
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
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(UserProfile obj)

        {
            if (ModelState.IsValid)//it check the weather model is valid or not  for a input
            {
                _db.UserProfile.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)

        {
        UserProfile? user = _db.UserProfile.FirstOrDefault(x => x.Id == id);
            _db.UserProfile.Remove(user);
            _db.SaveChanges(true);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int? id)

        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            UserProfile? userData = _db.UserProfile.Find(id);
            UserProfile? user = _db.UserProfile.FirstOrDefault(x => x.Id == id);
            UserProfile? user1 = _db.UserProfile.Where(x => x.Id == id).FirstOrDefault();
            if (userData == null)
            {
                return NotFound();
            }
            return View(userData);
        }
        [HttpPost]
        public IActionResult Update(UserProfile user)
        {  

            if (ModelState.IsValid)//it check the weather model is valid or not  for a input
            { 
                _db.UserProfile.Update(user);
                _db.SaveChanges();
                TempData["success"] = "User update Successfully!";
                return RedirectToAction("Index");
            }
            return View();
        }  
      


    }
}


