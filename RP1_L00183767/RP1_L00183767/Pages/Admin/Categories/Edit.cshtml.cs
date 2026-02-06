using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RP1__L00183767.DataAccess.DataAccess;
using RP1__L00183767.Models.Models;
using RP1_L00183767.DataAccess.Repository;

namespace RP1__L00183767.Pages.Admin.Categories
{
    public class EditModel : PageModel
    {
        private readonly ICategoryRepository _categoryRepo;
        public EditModel(ICategoryRepository categoryRepo)
        {
           _categoryRepo = categoryRepo;

        }

        public Category Category { get; set; }
        public void OnGet(int id)
        {
            Category = _categoryRepo.Get(id);

        }

        public IActionResult OnPost(Category category)
        {
            if(ModelState.IsValid)
            {
                _categoryRepo.Update(category);
                _categoryRepo.SaveAll();
            }
          
            return RedirectToPage("Index");
        }
    }
}
