using Dotnet_Mvc.DataAccess.Data;
using Dotnet_Mvc.DataAccess.Repository.IRepositroy;
using DotNet_Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Mvc.DataAccess.Repository
{
    public class ProductRepository : Repoistory<Products>, IProductsRepository

       
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db):base(db)
        {
        _db= db;

        }
        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Products obj)
        {
           var productItem = _db.Products.FirstOrDefault(u=>u.Id == obj.Id);    
            if (productItem != null)
            {
                productItem.Id = obj.Id;
                productItem.Name = obj.Name;    
                productItem.Description = obj.Description;
                productItem.Price = obj.Price;  
                if(obj.ImageURl != null)
                {
                    productItem.ImageURl= obj.ImageURl; 
                }
            }

        }
    }
}
