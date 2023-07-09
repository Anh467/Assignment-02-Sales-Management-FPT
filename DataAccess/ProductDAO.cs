using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BusinessObject.Models;
using Microsoft.Data.SqlClient;
namespace DataAccess
{
    public class ProductDAO: BaseDAL
    {
        private static ProductDAO instance = null;
        public static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                return instance;
            }
        }
        public IEnumerable<Product> GetProducts()
        {
            string query= " SELECT ProductID, CategoryID, ProductName, Weight, UnitPrice, UnitslnStock "
                        + " FROM dbo.Product";
            IDataReader dataReader = null;
            var products= new List<Product>();
            try
            {
                dataReader= dataProvider.GetDataReader(query, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    products.Add(new Product()
                    {
                        ProductId= dataReader.GetInt32(0),
                        CategoryId= dataReader.GetInt32(1),
                        ProductName= dataReader.GetString(2),
                        Weight= dataReader.GetString(3),
                        UnitPrice= dataReader.GetDecimal(4),
                        UnitslnStock= dataReader.GetInt32(5),
                    });
                }
            }catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
                dataReader.Close();
            }
            return products;
        }
        public Product GetProductsByID(int ProductID)
        {
            string query = " SELECT ProductID, CategoryID, ProductName, Weight, UnitPrice, UnitslnStock "
                        + " FROM dbo.Product "
                        + " WHERE ProductID = @ProductID ";
            IDataReader dataReader = null;
            Product product = null;
            try
            {
                var param = dataProvider.CreateParameter("@ProductID", 4, ProductID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(query, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    product= new Product()
                    {
                        ProductId = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitslnStock = dataReader.GetInt32(5),
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
                dataReader.Close();
            }
            return product;
        }
        public void Insert(Product product)
        {
            string query= " INSERT INTO dbo.Product "
                        + " VALUES "
                        + " (@CategoryID, @ProductName, @Weight, @UnitPrice, @UnitslnStock) ";
            try
            {
                var param= new List<SqlParameter>() { 
                    dataProvider.CreateParameter("@CategoryID", 4, product.CategoryId, DbType.Int32),
                    dataProvider.CreateParameter("@ProductName", 40, product.ProductName, DbType.String),
                    dataProvider.CreateParameter("@Weight", 20, product.Weight, DbType.String),
                    dataProvider.CreateParameter("@UnitPrice", 4, product.UnitPrice, DbType.Decimal),
                    dataProvider.CreateParameter("@UnitslnStock", 4, product.UnitslnStock, DbType.Int32),
                };
                dataProvider.DUC(query, CommandType.Text, param.ToArray());
            }catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public void Update(Product product)
        {
            string query = " UPDATE dbo.Product "
                        + " SET CategoryID = @CategoryID, ProductName = @ProductName, Weight = @Weight, UnitPrice = @UnitPrice, UnitslnStock = @UnitslnStock "
                        + " WHERE ProductID = @ProductID "; 
            try
            {
                if (GetProductsByID(product.ProductId) == null) throw new Exception($"Product with ID= {product.ProductId} doesn;t exist");
                var param = new List<SqlParameter>() {
                    dataProvider.CreateParameter("@ProductID", 4, product.ProductId, DbType.Int32),
                    dataProvider.CreateParameter("@CategoryID", 4, product.CategoryId, DbType.Int32),
                    dataProvider.CreateParameter("@ProductName", 40, product.ProductName, DbType.String),
                    dataProvider.CreateParameter("@Weight", 20, product.Weight, DbType.String),
                    dataProvider.CreateParameter("@UnitPrice", 4, product.UnitPrice, DbType.Decimal),
                    dataProvider.CreateParameter("@UnitslnStock", 4, product.UnitslnStock, DbType.Int32),
                };
                dataProvider.DUC(query, CommandType.Text, param.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public void Delete(int ProductID)
        {
            string query= " DELETE dbo.Product "
                        + " WHERE ProductID = @ProductID ";
            try
            {
                if (GetProductsByID(ProductID) == null) throw new Exception($"Product with ID= {ProductID} doesn;t exist");
                var param = dataProvider.CreateParameter("@ProductID", 4, ProductID, DbType.Int32);
                    
                dataProvider.DUC(query, CommandType.Text, param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public (List<SqlParameter>,string) getCondtion((int ProductID, string ProductName,
            double PriceLower, double PriceUpper,
            double StockLower, double StockUpper) search)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                dataProvider.CreateParameter("@ProductName", 40,search.ProductName, DbType.String),
            };
            string str = "where ProductName LIKE '%' + TRIM(@ProductName) + '%' ";
            if (search.ProductID > 0)
            {
                str += " and ProductID = @ProductID ";
                param.Add(dataProvider.CreateParameter("@ProductID", 4, search.ProductID, DbType.Int32));
            }
                
            if (search.PriceLower > 0 && search.PriceUpper > 0)
            {
                str += " and UnitPrice BETWEEN @PriceLower AND @PriceUpper ";
                param.Add(dataProvider.CreateParameter("@PriceLower", 4, search.PriceLower, DbType.Double));
                param.Add(dataProvider.CreateParameter("@PriceUpper", 4, search.PriceUpper, DbType.Double));
            }

            if (search.StockLower > 0 && search.StockUpper > 0)
            {
                str += " and UnitPrice BETWEEN @StockLower AND @StockUpper ";
                param.Add(dataProvider.CreateParameter("@StockLower", 4, search.StockLower, DbType.Int32));
                param.Add(dataProvider.CreateParameter("@StockUpper", 4, search.StockUpper, DbType.Double));

            }

            return (param, str);
        }
        public IEnumerable<Product> GetProducts((int pageIndex, string orderBy, bool ASC) sort,
                                                (int ProductID, string ProductName,
                                                double PriceLower, double PriceUpper,
                                                double StockLower, double StockUpper) search)
        {
            (List<SqlParameter> param, string condition) getCondition= getCondtion(search);
            string query = " DECLARE @Offset INT = " + sort.pageIndex + " ; "
                        + " DECLARE @FetchCount INT = 5; "
                        + " SELECT ProductID, CategoryID, ProductName, Weight, UnitPrice, UnitslnStock "
                            + " FROM dbo.Product "
                            + getCondition.condition
                            + " ORDER BY "+sort.orderBy.Trim()+" " + (sort.ASC ? "ASC" : "desc")
                        + " OFFSET(@Offset - 1) * @FetchCount ROWS "
                        + " FETCH NEXT @FetchCount ROWS ONLY ";
            IDataReader dataReader = null;
            var products = new List<Product>();
            try
            {
                dataReader = dataProvider.GetDataReader(query, CommandType.Text, out connection, getCondition.param.ToArray());
                while (dataReader.Read())
                {
                    products.Add(new Product()
                    {
                        ProductId = dataReader.GetInt32(0),
                        CategoryId = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitslnStock = dataReader.GetInt32(5),
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
                dataReader.Close();
            }
            return products;
        }
    }

}
