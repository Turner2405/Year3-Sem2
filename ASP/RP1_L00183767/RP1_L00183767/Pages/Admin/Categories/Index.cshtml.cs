using Microsoft.AspNetCore.Mvc.RazorPages;
using RP1__L00183767.Models.Models;
using RP1__L00183767.DataAccess.DataAccess;
using RP1_L00183767.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;


namespace RP1__L00183767.Pages.Admin.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ICategoryRepository __categoryRepo;
        public IEnumerable<Category> Categories;
        public IndexModel(ICategoryRepository categoryRepo)
        {
            __categoryRepo = categoryRepo;
        }

        public void OnGet()
        {
            Categories = __categoryRepo.GetAll();
        }
    }
}
