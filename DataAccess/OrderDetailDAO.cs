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
    public class OrderDetailDAO: BaseDAL
    {
        private static OrderDetailDAO instance = null;
        public static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                return instance;
            }
        }
        //get By ID
        public OrderDetail GetOrderDetailByID(int OrderID, int ProductID)
        {
            string query = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount"
                        + " FROM dbo.OrderDetail "
                        + " WHERE OrderID = @OrderID AND ProductID= @ProductID";
            OrderDetail orderDetail = null;
            IDataReader dataReader = null;
            try
            {
                var param = new List<SqlParameter>() {
                    dataProvider.CreateParameter("@OrderID", 4, OrderID, DbType.Int32),
                    dataProvider.CreateParameter("@ProductID", 4, ProductID, DbType.Int32),
                };
                    
                dataReader = dataProvider.GetDataReader(query, CommandType.Text, out connection, param.ToArray());
                while (dataReader.Read())
                {
                    orderDetail = new OrderDetail()
                    {
                        OrderId = dataReader.GetInt32(0),
                        ProductId = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = dataReader.GetDouble(4),
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
            return orderDetail;
        }
        public IEnumerable<OrderDetail> GetOrderDetailByID(int OrderID)
        {
            string query = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount"
                        + " FROM dbo.OrderDetail "
                        + " WHERE OrderID = @OrderID ";
            var orderDetails = new List<OrderDetail>();
            IDataReader dataReader = null;
            try
            {
                var param = dataProvider.CreateParameter("@OrderID", 4, OrderID, DbType.Int32);

                dataReader = dataProvider.GetDataReader(query, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    orderDetails.Add( new OrderDetail()
                    {
                        OrderId = dataReader.GetInt32(0),
                        ProductId = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = dataReader.GetDouble(4),
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
            return orderDetails;
        }
        //get List
        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            string query = " SELECT OrderID, ProductID, UnitPrice, Quantity, Discount "
                        + " FROM dbo.OrderDetail";
            var orderDetails = new List<OrderDetail>();
            IDataReader dataReader = null;
            try
            {
                dataReader = dataProvider.GetDataReader(query, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orderDetails.Add(new OrderDetail()
                    {
                        OrderId = dataReader.GetInt32(0),
                        ProductId = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = dataReader.GetDouble(4),
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
            return orderDetails;
        }
        public void Insert(OrderDetail orderDetail)
        {
            string query = " INSERT INTO dbo.OrderDetail "
                        + " VALUES "
                        + " (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount) ";
            try
            {
                var param = new List<SqlParameter>()
                {
                    dataProvider.CreateParameter("@OrderID", 4, orderDetail.OrderId, DbType.Int32),
                    dataProvider.CreateParameter("@ProductID", 4, orderDetail.ProductId, DbType.Int32),
                    dataProvider.CreateParameter("@UnitPrice", 4, orderDetail.UnitPrice, DbType.Decimal),
                    dataProvider.CreateParameter("@Quantity", 4, orderDetail.Quantity, DbType.Int32),
                    dataProvider.CreateParameter("@Discount", 4, orderDetail.Discount, DbType.Double),
                };
                dataProvider.DUC(query, CommandType.Text, param.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception("MemberDAO.GetMembers: " + ex.Message);
            }
            finally
            {
                //connection.Close();
            }
        }
        public void Delete(int OrderID, int ProductID)
        {
            string query = " DELETE dbo.OrderDetail "
                        + " WHERE OrderID = @OrderID AND ProductID = @ProductID ";
            try
            {
                if (GetOrderDetailByID(OrderID, ProductID) == null) throw new Exception($"Doesn't exist GetOrderDetailByID with OrderID= {OrderID} and ProductID= {ProductID} ");
                var param = new List<SqlParameter>() {
                    dataProvider.CreateParameter("@OrderID", 4, OrderID, DbType.Int32),
                    dataProvider.CreateParameter("@ProductID", 4, ProductID, DbType.Int32),
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
        public void Update(OrderDetail orderDetail)
        {
            string query = " UPDATE dbo.OrderDetail "
                        + " SET UnitPrice = @UnitPrice, Quantity = @Quantity, Discount = @Discount "
                        + " WHERE OrderID = @OrderID AND ProductID = @ProductID ";
            try
            {
                if (GetOrderDetailByID(orderDetail.OrderId, orderDetail.ProductId) == null) throw new Exception($"Doesn't exist GetOrderDetailByID with OrderID= {orderDetail.OrderId} and ProductID= {orderDetail.ProductId} ");
                var param = new List<SqlParameter>()
                {
                    dataProvider.CreateParameter("@OrderID", 4, orderDetail.OrderId, DbType.Int32),
                    dataProvider.CreateParameter("@ProductID", 4, orderDetail.ProductId, DbType.Int32),
                    dataProvider.CreateParameter("@UnitPrice", 4, orderDetail.UnitPrice, DbType.Decimal),
                    dataProvider.CreateParameter("@Quantity", 4, orderDetail.Quantity, DbType.Int32),
                    dataProvider.CreateParameter("@Discount", 4, orderDetail.Discount, DbType.Double),
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
    }

}
