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
        private readonly IProductsRepository _productRepo;
        public CategoryController(IProductsRepository db)
        {
            _productRepo = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()

        {
            List<Category> products = _productRepo.GetAll().ToList();
            return View(products);
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

            _productRepo.Add(obj);
             _productRepo.Save();


            return RedirectToAction("Add");

            }
            return View();

        }
        public IActionResult Update(int? id)
        {
            if (id!=null)
            {
                Category category = _productRepo.Get(product => product.Id == id);
                if (category != null)
                {
                    return View(category);
                }

               
            }
            return NotFound();  
           

        }
        [HttpPost]
        public IActionResult Update(Category category) {
            if (ModelState.IsValid)
            {
              
                _productRepo.Update(category);
                _productRepo.Save();
                return RedirectToAction("Add");   

            }
            
            return View();
        
        }
        public IActionResult Delete(int? id) { 
            if (id!=null)
            {
                Category category = _productRepo.Get(product=>product.Id == id);    
                if (category != null) 
                {
                    _productRepo.Remove(category);  
                    _productRepo.Save();
                  
                }
            }
            return RedirectToAction("Add");

        }
    }

}