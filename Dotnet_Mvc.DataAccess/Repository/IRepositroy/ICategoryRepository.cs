using DotNet_Mvc.Models;
using DotNet_Mvc.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Mvc.DataAccess.Repository.IRepositroy
{
    public interface ICategoryRepository:IRepository<Category>
    {
        Task<Category> Add(CategoryDto categoryDto);
        public void Update(Category obj);
        public void Save();
    }
}