using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RP1__L00183767.DataAccess.DataAccess;
using RP1__L00183767.Models.Models;


namespace RP1__L00183767.Pages.Admin.Categories
{
    public class CreateModel : PageModel
    {
        private readonly AppDBContext _dbContext;
        public CreateModel(AppDBContext dbContext)
        {
            _dbContext = dbContext;
           
        }

        public Category Category { get; set; }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost(Category category)
        {
            if(ModelState.IsValid)
            {
                await _dbContext.Categories.AddAsync(category);
                await _dbContext.SaveChangesAsync();
            }
          
            return RedirectToPage("Index");
        }
    }
}
