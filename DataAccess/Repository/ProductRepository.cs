using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void Delete(int ProductID) => ProductDAO.Instance.Delete(ProductID);  

        public IEnumerable<Product> GetProducts() => ProductDAO.Instance.GetProducts();

        public IEnumerable<Product> GetProducts((int pageIndex, string orderBy, bool ASC) sort,
                                                (int ProductID, string ProductName,
                                                double PriceLower, double PriceUpper,
                                                double StockLower, double StockUpper) search) 
            => ProductDAO.Instance.GetProducts(sort, search);

        public Product GetProductsByID(int ProductID) => ProductDAO.Instance.GetProductsByID(ProductID);

        public void Insert(Product product) => ProductDAO.Instance.Insert(product);

        public void Update(Product product) => ProductDAO.Instance.Update(product);
    }
}
