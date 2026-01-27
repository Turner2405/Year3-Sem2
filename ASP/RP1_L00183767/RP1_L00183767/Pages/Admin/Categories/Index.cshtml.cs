using Microsoft.AspNetCore.Mvc.RazorPages;
using RP1__L00183767.Models.Models;
using RP1__L00183767.DataAccess.DataAccess;


namespace RP1__L00183767.Pages.Admin.Categories
{
    public class IndexModel : PageModel
    {
        private readonly AppDBContext _dbContext;
        public IEnumerable<Category> Categories;
        public IndexModel(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            Categories = _dbContext.Categories;
        }
    }
}
