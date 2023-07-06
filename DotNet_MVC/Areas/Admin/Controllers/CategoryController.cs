using AutoMapper;
using Dotnet_Mvc.DataAccess.Data;
using Dotnet_Mvc.DataAccess.Repository.IRepositroy;
using DotNet_Mvc.Models;
using DotNet_Mvc.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace Dotnet_Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]


    public class CategoryController : Controller

    {
        private readonly ICategoryRepository _CategoryRepo;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryRepository db,
            IMapper mapper)
        {
            _CategoryRepo = db;
            _mapper = mapper;
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
        public async Task <IActionResult> Create(Category obj)
        {
            //if(ModelState.IsValid)
            //{
            //    var dto = new CategoryDto()
            //    {
            //        Id = obj.Id,
            //        Name = obj.Name,
            //        DisplayOrder = obj.DisplayOrder,
            //    };
            CategoryDto dto=_mapper.Map<CategoryDto>(obj);
                await _CategoryRepo.Add(dto);
                 _CategoryRepo.Save();
            return RedirectToAction("Index");
            //}
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