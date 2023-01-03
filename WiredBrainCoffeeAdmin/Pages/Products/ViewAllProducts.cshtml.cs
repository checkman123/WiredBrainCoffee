using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffeeAdmin.Data;

namespace WiredBrainCoffeeAdmin.Pages.Products
{
    public class ViewAllProductModel : PageModel
    {
        private IProductRepository productRepo;
        public List<Product> Products { get; set; }

        public ViewAllProductModel(IProductRepository productRepository)
        {
            this.productRepo = productRepository;
        }
        public void OnGet()
        {
            Products = productRepo.GetAll();
        }
    }
}
