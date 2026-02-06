using FragranceStore__L00183767.DataAccess.DataAccess;
using FragranceStore__L00183767.Models.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace FragranceStore__L00183767.Pages.Admin.Brands
{
    public class IndexModel : PageModel
    {
        private readonly AppDBContext _dbContext;
        public IEnumerable<Brand> Brands;
        public IndexModel(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            Brands = _dbContext.Brands;
        }
    }
}
