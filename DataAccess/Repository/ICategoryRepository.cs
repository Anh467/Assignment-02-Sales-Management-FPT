using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;
namespace DataAccess.Repository
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategories();
        public Category GetCategory(int CategoryId);
        public void Insert(Category category);
        public void Update(Category category);
        public void Delete(int CategoryId);
    }
}
