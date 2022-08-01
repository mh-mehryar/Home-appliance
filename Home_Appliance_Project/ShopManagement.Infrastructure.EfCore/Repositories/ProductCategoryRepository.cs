using ShopManagement.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Infrastructure.EfCore.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly ShopContext _context;
        public ProductCategoryRepository(ShopContext context)
        {
            _context = context;
        }
        public void Add(ProductCategory entity)
        {
            _context.ProductCategories.Add(entity);
            _context.SaveChanges();
        }
        public ProductCategory Get(long id)
        {
            return _context.ProductCategories.Find(id);
        }
        public List<ProductCategory> GetAll()
        {
            return _context.ProductCategories.ToList();
        }
    }
   
}
