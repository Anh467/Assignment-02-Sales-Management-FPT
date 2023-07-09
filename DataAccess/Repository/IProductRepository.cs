using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;
namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();
        public Product GetProductsByID(int ProductID);
        public IEnumerable<Product> GetProducts((int pageIndex, string orderBy, bool ASC) sort,
                                                (int ProductID, string ProductName,
                                                double PriceLower, double PriceUpper,
                                                double StockLower, double StockUpper) search);
        public void Insert(Product product);
        public void Update(Product product);
        public void Delete(int ProductID);
    }
}
