using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;
namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void Delete(int OrderID, int ProductID) => OrderDetailDAO.Instance.Delete(OrderID, ProductID);
        public OrderDetail GetOrderDetailByID(int OrderID, int ProductID) => OrderDetailDAO.Instance.GetOrderDetailByID(OrderID, ProductID);

        public IEnumerable<OrderDetail> GetOrderDetailByID(int OrderID) => OrderDetailDAO.Instance.GetOrderDetailByID(OrderID);

        public IEnumerable<OrderDetail> GetOrderDetails() => OrderDetailDAO.Instance.GetOrderDetails();
        public void Insert(OrderDetail orderDetail) => OrderDetailDAO.Instance.Insert(orderDetail);
        public void Update(OrderDetail orderDetail) => OrderDetailDAO.Instance.Update(orderDetail);
    }
}
