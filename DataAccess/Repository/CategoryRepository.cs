using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace DataAccess.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public void Delete(int CategoryId) => CategoryDAO.Instance.Delete(CategoryId);

        public IEnumerable<Category> GetCategories() => CategoryDAO.Instance.GetCategories();

        public Category GetCategory(int CategoryId) => CategoryDAO.Instance.GetCategory(CategoryId);
        public void Insert(Category category) => CategoryDAO.Instance.Insert(category);

        public void Update(Category category) => CategoryDAO.Instance.Update(category);
    }
}
