using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;
namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetOrderDetails();
        public OrderDetail GetOrderDetailByID(int OrderID, int ProductID);
        public IEnumerable<OrderDetail> GetOrderDetailByID(int OrderID);
        public void Insert(OrderDetail orderDetail);
        public void Update(OrderDetail orderDetail);
        public void Delete(int OrderID, int ProductID);
    }
}
