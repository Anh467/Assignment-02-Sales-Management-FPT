using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;
namespace DataAccess.Repository
{
    public interface IOrderrRepository
    {
        public IEnumerable<Orderr> GetOrderrs();
        public IEnumerable<Orderr> GetOrderrs(int offset, (string orderby, bool ASC) sort);
        public IEnumerable<Orderr> GetOrderrs(int offset, int MemberID, (string orderby, bool ASC) sort);
        public Orderr GetOrderrByID(int OrderID);
        public int Insert(Orderr Orderr);
        public void Update(Orderr Orderr);
        public void Delete(int OrderID);
    }
}
