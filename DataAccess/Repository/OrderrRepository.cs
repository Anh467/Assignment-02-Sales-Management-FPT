using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderrRepository : IOrderrRepository
    {
        public void Delete(int OrderID) => OrderrDAO.Instance.Delete(OrderID);

        public Orderr GetOrderrByID(int OrderID) => OrderrDAO.Instance.GetOrderrByID(OrderID);

        public IEnumerable<Orderr> GetOrderrs() => OrderrDAO.Instance.GetOrderrs();

        public IEnumerable<Orderr> GetOrderrs(int offset, (string orderby, bool ASC) sort) => OrderrDAO.Instance.GetOrderrs(offset, sort);

        public IEnumerable<Orderr> GetOrderrs(int offset, int MemberID, (string orderby, bool ASC) sort)
        => OrderrDAO.Instance.GetOrderrs(offset, MemberID, sort);   

        public int Insert(Orderr Orderr) => OrderrDAO.Instance.Insert(Orderr);

        public void Update(Orderr Orderr) => OrderrDAO.Instance.Update(Orderr);
    }
}
