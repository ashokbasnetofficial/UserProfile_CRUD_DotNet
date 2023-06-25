using Dotnet_Mvc.DataAccess.Data;
using Dotnet_Mvc.DataAccess.Repository.IRepositroy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Mvc.DataAccess.Repository
{
    public class Repoistory<T> : IRepository<T> where T : class
    { 
        private readonly ApplicationDbContext _context;
        internal DbSet<T> dbSet;
        public Repoistory(ApplicationDbContext db) {
            _context = db;
            this.dbSet =_context.Set<T>();
            //_db.UserProfile=dbSet
        
        }
        public void Add(T item)
        {
            dbSet.Add(item);
            
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            return query.FirstOrDefault();

           
        }

        public IEnumerable<T> GetAll()
        {
          IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public void Remove(T item)
        {
            dbSet.Remove(item);
        }

        public void RemoveRange(IEnumerable<T> item)
        {
            dbSet.RemoveRange(item);
        }
    }
}
