using DotNet_Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Mvc.DataAccess.Repository.IRepositroy
{
    public interface IUserRepository: IRepository<UserProfile>
    {
        public void Update(UserProfile obj);
        public void Save();
    }
}
