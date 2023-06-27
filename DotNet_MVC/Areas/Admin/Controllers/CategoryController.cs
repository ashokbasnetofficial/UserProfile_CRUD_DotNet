using Dotnet_Mvc.DataAccess.Data;
using Dotnet_Mvc.DataAccess.Repository.IRepositroy;
using DotNet_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace Dotnet_Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]


    public class CategoryController : Controller

    {
        private readonly ICategoryRepository _CategoryRepo;
        public CategoryController(ICategoryRepository db)
        {
            _CategoryRepo = db;
        }
      
        public IActionResult Index()

        {
            List<Category> categories = _CategoryRepo.GetAll().ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if(ModelState.IsValid)
            {

            _CategoryRepo.Add(obj);
             _CategoryRepo.Save();


            return RedirectToAction("Index");

            }
            return View();

        }
        public IActionResult Update(int? id)
        {
            if (id!=null)
            {
                Category category = _CategoryRepo.Get(Category => Category.Id == id);
                if (category != null)
                {
                    return View(category);
                }

               
            }
            return NotFound();  
           

        }
        [HttpPost]
        public IActionResult Update(Category obj) {
            if (ModelState.IsValid)
            {
              
                _CategoryRepo.Update(obj);
                _CategoryRepo.Save();
                return RedirectToAction("Index");   

            }
            
            return View();
        
        }
        public IActionResult Delete(int? id) { 
            if (id!=null)
            {
                Category category = _CategoryRepo.Get(Category=>Category.Id == id);    
                if (category != null) 
                {
                    _CategoryRepo.Remove(category);  
                    _CategoryRepo.Save();
                  
                }
            }
            return RedirectToAction("Index");

        }
    }

}