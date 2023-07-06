using Dotnet_Mvc.DataAccess.Data;
using Dotnet_Mvc.DataAccess.Repository.IRepositroy;
using DotNet_Mvc.Models;
using DotNet_Mvc.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Mvc.DataAccess.Repository
{
    public class CategoryRepository : Repoistory<Category>, ICategoryRepository

       
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db):base(db)
        {
        _db= db;

        }

        public async Task<Category> Add(CategoryDto categoryDto)
        {
            Category category = new Category()
            {
                Id=categoryDto.Id,
                Name=categoryDto.Name,
                DisplayOrder = categoryDto.DisplayOrder,
            };
            await _db.AddAsync(category);
            _db.SaveChanges();
            return category;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Category obj)
        {
            _db.Update(obj);
        }
    }
}
