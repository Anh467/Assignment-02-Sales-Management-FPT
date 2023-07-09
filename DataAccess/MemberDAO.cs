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
    public class MemberDAO : BaseDAL
    {
        private static MemberDAO instance = null;
        public static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                return instance;
            }
        }
        public ICollection<Orderr> getOrderrByMemberID(int MemberID){
            string query = "SELECT OrderID, MemberID, OrderDate, RequiredDate, ShippedDate, Frieght "
                        + " FROM dbo.Orderr "
                        + " WHERE MemberID = @MemberID ";
            IDataReader dataReader = null;
            var orderrs = new List<Orderr>();
            try
            {
                var param = dataProvider.CreateParameter("@MemberID", 4, MemberID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(query, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    orderrs.Add(new Orderr()
                    {
                        OrderId= dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Frieght= dataReader.GetDecimal(5),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("MemberDAO.GetMembers: " + ex.Message);
            }
            finally
            {
                dataReader.Close();
                connection.Close();
            }
            return orderrs;
        }
        public Member GetMemberByID(int MemberID)
        {
            string query = " SELECT MemberID, Email, CompanyName, City, Contry, Password "
                    + " FROM dbo.Member "
                    + " WHERE MemberID = @MemberID ";
            IDataReader dataReader = null;
            Member member= null;
            try
            {
                var param = dataProvider.CreateParameter("@MemberID", 4, MemberID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(query, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    ICollection<Orderr> orderrs = getOrderrByMemberID(MemberID);
                    member = new Member()
                    {
                        MemberId = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Contry = dataReader.GetString(4),
                        Password = dataReader.GetString(5),
                        Orderrs = orderrs
                    };
                }
            }catch (Exception ex)
            {
                throw new Exception("MemberDAO.GetMemberByID:" + ex.Message);
            }
            finally
            {
                dataReader?.Close();
                connection.Close();
            }
            return member;
        }
        public IEnumerable<Member> GetMembers()
        {
            string query = "SELECT MemberID, Email, CompanyName, City, Contry, Password "
                        + " FROM dbo.Member";
            IDataReader dataReader = null;
            var members = new List<Member>();
            try
            {
                dataReader = dataProvider.GetDataReader(query, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    int MemberID= dataReader.GetInt32(0);
                    ICollection<Orderr> orderrs = getOrderrByMemberID(MemberID);
                    members.Add(new Member()
                    {
                        MemberId = MemberID,
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Contry = dataReader.GetString(4),
                        Password = dataReader.GetString(5),
                        Orderrs= orderrs,
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("MemberDAO.GetMembers: " + ex.Message);
            }
            finally
            {
                dataReader.Close();
                 connection.Close();
            }
            return  members;
        }
        public void Insert(Member member)
        {
            string query= " INSERT INTO dbo.Member "
                        +" VALUES "
                        + " (@Email, @CompanyName, @City, @Contry, @Password) ";
            try
            {
                var param = new List<SqlParameter>()
                {
                    dataProvider.CreateParameter("@Email", 100, member.Email, DbType.String),
                    dataProvider.CreateParameter("@CompanyName", 40, member.CompanyName, DbType.String),
                    dataProvider.CreateParameter("@City", 15, member.City, DbType.String),
                    dataProvider.CreateParameter("@Contry", 15, member.Contry, DbType.String),
                    dataProvider.CreateParameter("@Password", 30, member.Password, DbType.String),
                };
                dataProvider.DUC(query, CommandType.Text, param.ToArray());
            }catch (Exception ex)
            {
                throw new Exception("MemberDAO.GetMembers: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void Delete(int MemberID)
        {
            string query = "DELETE dbo.Member "
                        + " WHERE MemberID = @MemberID";
            try
            {
                if (GetMemberByID(MemberID) == null) throw new Exception("Doesn't exist member with ID: " + MemberID);
                var param = dataProvider.CreateParameter("@MemberID", 4, MemberID, DbType.Int32);
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
        public void Update(Member member)
        {
            string query = " UPDATE dbo.Member "
                        +" SET Email = @Email, CompanyName = @CompanyName, City = @City, Contry = @Contry, Password = @Password "
                        +" WHERE MemberID = @MemberID ";
            try
            {
                if (GetMemberByID(member.MemberId) == null) 
                    throw new Exception("Doesn't exist member with ID: " + member.MemberId);
                var param = new List<SqlParameter>()
                {
                    dataProvider.CreateParameter("@Email", 100, member.Email, DbType.String),
                    dataProvider.CreateParameter("@CompanyName", 40, member.CompanyName, DbType.String),
                    dataProvider.CreateParameter("@City", 15, member.City, DbType.String),
                    dataProvider.CreateParameter("@Contry", 15, member.Contry, DbType.String),
                    dataProvider.CreateParameter("@Password", 30, member.Password, DbType.String),
                    dataProvider.CreateParameter("@MemberID", 4, member.MemberId, DbType.Int32),
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
        public Member CheckExistAccount(string Email, string Password)
        {
            string query= " SELECT MemberID, Email, CompanyName, City, Contry, Password "
                    + " from dbo.Member "
                    +" where Email = @Email and Password = @Password ";
            IDataReader dataReader = null;
            Member member = null;
            try
            {
                var param = new List<SqlParameter>()
                {
                    dataProvider.CreateParameter("@Email", 100, Email, DbType.String),
                    dataProvider.CreateParameter("@Password", 30, Password, DbType.String)
                };
                dataReader = dataProvider.GetDataReader(query, CommandType.Text, out connection, param.ToArray());
                while (dataReader.Read())
                {
                    member = new Member()
                    {
                        MemberId = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Contry = dataReader.GetString(4),
                        Password = dataReader.GetString(5),
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
            return member;
        }
    }
}
