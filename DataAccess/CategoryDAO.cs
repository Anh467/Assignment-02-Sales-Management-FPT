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
    internal class CategoryDAO:BaseDAL
    {
        private static CategoryDAO instance = null;
        public static readonly object instanceLock = new object();
        private CategoryDAO() { }
        public static CategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                return instance;
            }
        }
        public IEnumerable<Category> GetCategories()
        {
            string query = " SELECT CategoryID, CategoryName "
                        + " FROM dbo.Category ";
            IDataReader dataReader = null;
            List<Category> categories = new List<Category>();
            try
            {
                dataReader = dataProvider.GetDataReader(query, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    categories.Add(new Category()
                    {
                        CategoryId= dataReader.GetInt32(0),
                        CategoryName= dataReader.GetString(1)
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
            return categories;
        }
        public Category GetCategory(int CategoryId)
        {
            string query = "SELECT CategoryID, CategoryName "
                    + " FROM dbo.Category "
                    + " WHERE CategoryID = @CategoryID ";
            IDataReader dataReader = null;
            Category category = null;
            try
            {
                var param = dataProvider.CreateParameter("@CategoryID", 4, CategoryId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(query, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    category= new Category()
                    {
                        CategoryId = dataReader.GetInt32(0),
                        CategoryName = dataReader.GetString(1)
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
            return category;
        }
        public void Insert(Category category)
        {
            string query = " INSERT INTO dbo.Category " 
                        + " VALUES "
                        + " ( @CategoryName ) ";
            try { 
                var param= dataProvider.CreateParameter("@CategoryName", 40, category.CategoryName, DbType.String);
                dataProvider.DUC(query, CommandType.Text, param);
            }catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public void Update(Category category)
        {
            string query= " UPDATE dbo.Category "
                    + " SET CategoryName = @CategoryName "
                    + " WHERE CategoryID = @CategoryID ";
            try
            {
                var param = new List<SqlParameter>()
                {
                    dataProvider.CreateParameter("@CategoryName", 40, category.CategoryName, DbType.String),
                    dataProvider.CreateParameter("@CategoryID", 4, category.CategoryId, DbType.Int32)
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
        public void Delete(int CategoryId)
        {
            string query = " DELETE dbo.Category "
                        + " WHERE CategoryID = @CategoryID ";
            try
            {
                var param = dataProvider.CreateParameter("@CategoryID", 4, CategoryId, DbType.Int32);
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
    }
}
