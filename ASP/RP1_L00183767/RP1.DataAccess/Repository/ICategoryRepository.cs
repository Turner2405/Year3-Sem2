using RP1__L00183767.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP1_L00183767.DataAccess.Repository
{
    public interface ICategoryRepository: IRepository<Category>
    {
        void SaveAll();
    }
}
