using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RP1__L00183767.DataAccess.DataAccess;
using RP1__L00183767.Models.Models;
using RP1_L00183767.DataAccess.Repository;


namespace RP1__L00183767.Pages.Admin.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ICategoryRepository _categoryrepo;
        public CreateModel(ICategoryRepository categoryrepo)
        {
            _categoryrepo = categoryrepo;
           
        }

        public Category Category { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost(Category category)
        {
            if(ModelState.IsValid)
            {
                 _categoryrepo.Add(category);
                 _categoryrepo.SaveAll();
            }
          
            return RedirectToPage("Index");
        }
    }
}
