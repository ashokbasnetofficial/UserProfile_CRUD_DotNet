using Dotnet_Mvc.DataAccess.Data;

using Dotnet_Mvc.DataAccess.Repository.IRepositroy;
using DotNet_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserProfileController : Controller
    {

        private readonly ICategoryRepository _categoryRepo;
        public UserProfileController(ICategoryRepository db)
        {
            _categoryRepo = db;
        }
        public IActionResult Index()
        {
            //  var userProfile = _db.UserProfile.ToList();
            List<UserProfile> users = _categoryRepo.GetAll().ToList();
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
                _categoryRepo.Add(obj);
                _categoryRepo.Save();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int? id)

        {
            UserProfile? user = _categoryRepo.Get(x => x.Id == id);
            _categoryRepo.Remove(user);
            _categoryRepo.Save();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int? id)

        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            UserProfile? userData = _categoryRepo.Get(x => x.Id == id);
            //UserProfile? user = _db.UserProfile.FirstOrDefault(x => x.Id == id);
            //UserProfile? user1 = _db.UserProfile.Where(x => x.Id == id).FirstOrDefault();
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
                _categoryRepo.Update(user);
                _categoryRepo.Save();
                TempData["success"] = "User update Successfully!";
                return RedirectToAction("Index");
            }
            return View();
        }



    }
}


