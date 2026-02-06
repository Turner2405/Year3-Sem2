using RP1__L00183767.DataAccess.DataAccess;
using RP1__L00183767.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP1_L00183767.DataAccess.Repository
{
    public class CategoryRepo : Repository<Category>, ICategoryRepository
    {
        private readonly AppDBContext _dbcontext;

        public CategoryRepo(AppDBContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public void SaveAll()
        {
            _dbcontext.SaveChanges();
        }
    }
}
