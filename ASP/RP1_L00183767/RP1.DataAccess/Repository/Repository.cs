using Microsoft.EntityFrameworkCore;
using RP1__L00183767.DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP1_L00183767.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDBContext _dbcontext;
        internal DbSet<T> dbSet;

        public Repository(AppDBContext dbcontext)
        {
            _dbcontext = dbcontext;
            this.dbSet = _dbcontext.Set<T>();
        }
        public void Add(T obj)
        {
            dbSet.Add(obj);
        }

        public void Delete(T obj)
        {
            dbSet.Remove(obj);
        }

        public T Get(int id)
        {
            if (id == 0)
                return null;

            else
                return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> list = dbSet;
            return list.ToList();
        }

        public void Update(T obj)
        {
            dbSet.Update(obj);
        }
    }
}
