using FragranceStore__L00183767.DataAccess.DataAccess;
using FragranceStore__L00183767.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace FragranceStore__L00183767.Pages.Admin.Brands
{
    public class CreateModel : PageModel
    {
        private readonly AppDBContext _dbContext;
        public CreateModel(AppDBContext dbContext)
        {
            _dbContext = dbContext;
           
        }

        public Brand Brand { get; set; }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost(Brand brand)
        {
            if(ModelState.IsValid)
            {
                await _dbContext.Brands.AddAsync(brand);
                await _dbContext.SaveChangesAsync();
            }
          
            return RedirectToPage("Index");
        }
    }
}
