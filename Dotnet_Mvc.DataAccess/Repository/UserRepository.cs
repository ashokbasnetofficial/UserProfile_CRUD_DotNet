using Dotnet_Mvc.DataAccess.Data;
using Dotnet_Mvc.DataAccess.Repository.IRepositroy;
using DotNet_Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Mvc.DataAccess.Repository
{
    public class UserRepository :Repoistory<UserProfile>, IUserRepository
    {
        private ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext db) :base(db) 
        {

            _db = db;
        }

        public void Save()
        {
           _db.SaveChanges();
        }

        public void Update(UserProfile obj)
        {
              _db.Update(obj);
        }
    }
}
