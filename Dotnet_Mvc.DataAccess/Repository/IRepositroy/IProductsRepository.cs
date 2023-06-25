﻿using DotNet_Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Mvc.DataAccess.Repository.IRepositroy
{
    public interface IProductsRepository:IRepository<Category>
    {
        public void Update(Category obj);
        public void Save();
    }
}