using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffeeAdmin.Data;

namespace WiredBrainCoffeeAdmin.Pages.Products
{
    public class AddProductModel : PageModel
    {
        private WiredContext wiredContext;
        public AddProductModel(WiredContext context) {
            this.wiredContext = context;
        }
        [BindProperty]
        public Product NewProduct {get; set;}
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            //Check if validation is passed
            if (ModelState.IsValid) {
                this.wiredContext.Products.Add(NewProduct);
                var changes = this.wiredContext.SaveChanges();

                return RedirectToPage("ViewAllProducts");
            }
            return Page();
        }
    }
}
