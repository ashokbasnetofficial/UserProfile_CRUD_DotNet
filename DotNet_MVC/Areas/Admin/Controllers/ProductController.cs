using Dotnet_Mvc.DataAccess.Data;
using Dotnet_Mvc.DataAccess.Repository.IRepositroy;
using DotNet_Mvc.Models;
using DotNet_Mvc.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dotnet_Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]


    public class ProductController : Controller

    {
        private readonly IProductsRepository _productRepo;
        private readonly ICategoryRepository _categoryRepo;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductController(IProductsRepository db,ICategoryRepository db1, IWebHostEnvironment webHostEnvironment)
        {
            _categoryRepo = db1;
            _productRepo = db;
           _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {

            List<Products> products = _productRepo.GetAll(includeProperties: "Category").ToList();


            return View(products);
        }
        public IActionResult Add()

        {  
            List<Products> products = _productRepo.GetAll(includeProperties:"Category").ToList();
          

            return View(products);
        }
        public IActionResult Upsert(int? id)
        {

          
            ProductVM ProductVM = new() {
                CategoryList = _categoryRepo.GetAll().ToList().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                Product = new Products()
            };
            if (id == null || id == 0)
            {
               return View(ProductVM);
            }
            else
            {
                ProductVM.Product = _productRepo.Get(x => x.Id == id);
                return View(ProductVM);  
            }
        
        }
        [HttpPost]
        public IActionResult Upsert(ProductVM obj,IFormFile? file)
        {
          
          
                if (ModelState.IsValid)
                    
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {

                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string productPath = Path.Combine(wwwRootPath, @"images\product");
                    if(!string.IsNullOrEmpty(obj.Product.ImageURl))
                    {
                        string oldImagePath = Path.Combine(wwwRootPath, obj.Product.ImageURl.TrimStart('\\'));
                        if(System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);    
                        }
                    }
                    using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }


                    obj.Product.ImageURl = @"\images\product\" + fileName;
                }
                if (obj.Product.Id == 0)
                {

                    _productRepo.Add(obj.Product);
                    _productRepo.Save();
                }
                else
                {
                    _productRepo.Update(obj.Product);
                    _productRepo.Save();
                }

            return RedirectToAction("Add");

            }
            else
            {
             
                    obj.CategoryList = _categoryRepo.GetAll().ToList().Select(u => new SelectListItem
                    {
                        Text = u.Name,
                        Value = u.Id.ToString()
                    });
                   return View(obj);

            }

            }
        public IActionResult Delete(int? id) { 
            if (id!=null)
            {
                Products category = _productRepo.Get(product=>product.Id == id);    
                if (category != null) 
                {
                    _productRepo.Remove(category);  
                    _productRepo.Save();
                  
                }
            }
            return RedirectToAction("Add");

        }
        [HttpGet]
        public IActionResult GetAll( )
        {
            List<Products> products = _productRepo.GetAll(includeProperties: "Category").ToList();
            return Json(new {data=products});

        }
    }

}