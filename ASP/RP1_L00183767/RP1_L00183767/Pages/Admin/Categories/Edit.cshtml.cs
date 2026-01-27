using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RP1__L00183767.DataAccess.DataAccess;
using RP1__L00183767.Models.Models;

namespace RP1__L00183767.Pages.Admin.Categories
{
    public class EditModel : PageModel
    {
        private readonly AppDBContext _dbContext;
        public EditModel(AppDBContext dbContext)
        {
            _dbContext = dbContext;
           
        }

        public Category Category { get; set; }
        public void OnGet(int id)
        {
            Category = _dbContext.Categories.Find(id);

        }

        public async Task<IActionResult> OnPost(Category category)
        {
            if(ModelState.IsValid)
            {
                 _dbContext.Categories.Update(category);
                await _dbContext.SaveChangesAsync();
            }
          
            return RedirectToPage("Index");
        }
    }
}
