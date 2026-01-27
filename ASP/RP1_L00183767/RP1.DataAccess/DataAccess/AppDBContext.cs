

using Microsoft.EntityFrameworkCore;
using RP1__L00183767.Models.Models;

namespace RP1__L00183767.DataAccess.DataAccess
{
    public class AppDBContext :DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        { 
            
        
        
        
        
        }
        public DbSet<Category> Categories { get; set; }



        
    }
}
