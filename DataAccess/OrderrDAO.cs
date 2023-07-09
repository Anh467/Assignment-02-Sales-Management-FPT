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
    public class OrderrDAO: BaseDAL
    {
        private static OrderrDAO instance = null;
        public static readonly object instanceLock = new object();
        private OrderrDAO() { }
        public static OrderrDAO Instance
        {
            get
            {
                lock (instanceLock)
                    if (instance == null)
                    {
                        instance = new OrderrDAO();
                    }
                return instance;
            }
        }
        //get By ID
        public Orderr GetOrderrByID(int OrderID)
        {
            string query = " SELECT OrderID, MemberID, OrderDate, RequiredDate, ShippedDate, Frieght "
                        + " FROM dbo.Orderr "
                        + " WHERE OrderID = @OrderID ";
            IDataReader dataReader = null;
            Orderr orderr = null;
            try
            {
                var param = dataProvider.CreateParameter("@OrderID", 4, OrderID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(query, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    orderr = new Orderr()
                    {
                        OrderId= dataReader.GetInt32(0),
                        MemberId= dataReader.GetInt32(1),
                        OrderDate= dataReader.GetDateTime(2),
                        RequiredDate= dataReader.GetDateTime(3),
                        ShippedDate= dataReader.GetDateTime(4),
                        Frieght= dataReader.GetDecimal(5),
                    };
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
            return orderr;
        }
        //get List
        public IEnumerable<Orderr> GetOrderrs()
        {
            string query = " SELECT OrderID, MemberID, OrderDate, RequiredDate, ShippedDate, Frieght "
                        + " FROM dbo.Orderr ";
            IDataReader dataReader = null;
            var orderrs = new List<Orderr>();
            try
            {
                dataReader = dataProvider.GetDataReader(query, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orderrs.Add( new Orderr()
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Frieght = dataReader.GetDecimal(5),
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
            return orderrs;
        }
        public IEnumerable<Orderr> GetOrderrs(int offset, (string orderby, bool ASC) sort)
        {
            string query = "DECLARE @Offset INT = @i; "
                        + " DECLARE @FetchCount INT = 5;  "

                        +  " SELECT OrderID, MemberID, OrderDate, RequiredDate, ShippedDate, Frieght"
                        +  " FROM dbo.Orderr "
                        + " ORDER BY "+ sort.orderby + (sort.ASC? " ":" DESC ")
                        +  " OFFSET(@Offset - 1) * @FetchCount ROWS "
                        +  " FETCH NEXT @FetchCount ROWS ONLY ";
            IDataReader dataReader = null;
            var orderrs = new List<Orderr>();
            try
            {
                var param = dataProvider.CreateParameter("@i", 4, offset, DbType.Int32);
                dataReader = dataProvider.GetDataReader(query, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    orderrs.Add(new Orderr()
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Frieght = dataReader.GetDecimal(5),
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
            return orderrs;
        }
        public IEnumerable<Orderr> GetOrderrs(int offset, int MemberID, (string orderby, bool ASC) sort)
        {
            string query = "DECLARE @Offset INT = @i; "
                        + " DECLARE @FetchCount INT = 5;  "

                        + " SELECT OrderID, MemberID, OrderDate, RequiredDate, ShippedDate, Frieght"
                        + " FROM dbo.Orderr " 
                        + " WHERE MemberID= @MemberID "
                        + " ORDER BY " + sort.orderby + (sort.ASC ? " " : " DESC ")
                        + " OFFSET(@Offset - 1) * @FetchCount ROWS "
                        + " FETCH NEXT @FetchCount ROWS ONLY ";
            IDataReader dataReader = null;
            var orderrs = new List<Orderr>();
            try
            {
                var param = new List<SqlParameter>()
                {
                    dataProvider.CreateParameter("@i", 4, offset, DbType.Int32),
                    dataProvider.CreateParameter("@MemberID", 4, MemberID, DbType.Int32)
                 };
                dataReader = dataProvider.GetDataReader(query, CommandType.Text, out connection, param.ToArray());
                while (dataReader.Read())
                {
                    orderrs.Add(new Orderr()
                    {
                        OrderId = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Frieght = dataReader.GetDecimal(5),
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
            return orderrs;
        }
        //Insert
        public int Insert(Orderr Orderr)
        {
            string query = " DECLARE @InsertedIDs TABLE (OrderID INT); " 
                           + " INSERT INTO dbo.Orderr " 
                           + " OUTPUT Inserted.OrderID INTO @InsertedIDs "
                            + " VALUES "
                            + " (@MemberID, @OrderDate, @RequiredDate, @ShippedDate, @Frieght) " 
                            + " SELECT OrderID FROM @InsertedIDs; ";
            IDataReader dataReader = null;
            int OrderID= 0;
            try
            {

                var param= new List<SqlParameter>()
                {
                    dataProvider.CreateParameter("@MemberID", 4, Orderr.MemberId, DbType.Int32),
                    dataProvider.CreateParameter("@OrderDate", 4, Orderr.OrderDate, DbType.DateTime),
                    dataProvider.CreateParameter("@RequiredDate", 4, Orderr.RequiredDate, DbType.DateTime),
                    dataProvider.CreateParameter("@ShippedDate", 4, Orderr.ShippedDate, DbType.DateTime),
                    dataProvider.CreateParameter("@Frieght", 4, Orderr.Frieght, DbType.Decimal),
                };
                dataReader =dataProvider.GetDataReader(query, CommandType.Text, out connection, param.ToArray());
                while (dataReader.Read())
                {
                    OrderID = dataReader.GetInt32(0);
                }
            }catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //connection.Close();
            }
            return OrderID;
        }
        // Delete
        public void Delete(int OrderID)
        {
            string query = " DELETE dbo.Orderr " 
                        + " WHERE OrderID = @OrderID ";
            try
            {
                if (GetOrderrByID(OrderID) == null) throw new Exception($"Order with ID {OrderID} doesn't exist");
                var param = dataProvider.CreateParameter("@OrderID", 4, OrderID, DbType.Int32);
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
        //Update
        public void Update(Orderr Orderr)
        {
            string query = " UPDATE dbo.Orderr "
                + " SET MemberID = @MemberID, OrderDate = @OrderDate, RequiredDate = @RequiredDate, ShippedDate = @ShippedDate, Frieght = @Frieght "
                + " WHERE OrderID = @OrderID ";
            try
            {
                var param = new List<SqlParameter>() {
                    dataProvider.CreateParameter("@OrderID", 4, Orderr.OrderId, DbType.Int32),
                    dataProvider.CreateParameter("@MemberID", 4, Orderr.MemberId, DbType.Int32),
                    dataProvider.CreateParameter("@OrderDate", 4, Orderr.OrderDate, DbType.DateTime),
                    dataProvider.CreateParameter("@RequiredDate", 4, Orderr.RequiredDate, DbType.DateTime),
                    dataProvider.CreateParameter("@ShippedDate", 4, Orderr.ShippedDate, DbType.DateTime),
                    dataProvider.CreateParameter("@Frieght", 4, Orderr.Frieght, DbType.Double),
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
