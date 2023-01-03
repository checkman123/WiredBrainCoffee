using Microsoft.EntityFrameworkCore;

namespace WiredBrainCoffeeAdmin.Data
{
    public class ProductRepository : IProductRepository
    {
        private WiredContext wiredContext;

        public ProductRepository(WiredContext context)
        {
            this.wiredContext = context;
        }
        public void Add(Product product)
        {
            this.wiredContext.Products.Add(product);
            this.wiredContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var deleteItem = wiredContext.Products.First(x => x.Id == id);
            wiredContext.Products.Remove(deleteItem);
            wiredContext.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return wiredContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            return wiredContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public void Update(Product product)
        {
            wiredContext.Entry(product).State = EntityState.Modified;
            wiredContext.SaveChanges();
        }
    }
}
