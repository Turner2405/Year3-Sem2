using FragranceStore__L00183767.DataAccess.DataAccess;
using FragranceStore__L00183767.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace FragranceStore__L00183767.Pages.Admin.Brands
{
    public class EditModel : PageModel
    {
        private readonly AppDBContext _dbContext;
        public EditModel(AppDBContext dbContext)
        {
            _dbContext = dbContext;
           
        }

        public Brand Brand { get; set; }
        public void OnGet(int id)
        {
            Brand = _dbContext.Brands.Find(id);
        }

        public async Task<IActionResult> OnPost(Brand brand)
        {
            if(ModelState.IsValid)
            {
                 _dbContext.Brands.Update(brand);
                await _dbContext.SaveChangesAsync();
            }
          
            return RedirectToPage("Index");
        }
    }
}
