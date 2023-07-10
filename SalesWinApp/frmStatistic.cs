using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Models;
using DataAccess.Repository;
namespace SalesWinApp
{
    public partial class frmStatistic : Form
    {
        IOrderrRepository orderrRepository = new OrderrRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        IProductRepository productRepository = new ProductRepository();
        List<Orderr> orderrstatic;
        List<Orderr> orderrs;
        List<OrderDetail> orderDetails;
        List<Product> products;
        BindingSource bindingSource;
        public frmStatistic()
        {
            InitializeComponent();
            loadOrderrs();
            
        }
        public void loadOrderrs()
        {
            products =(List<Product>) productRepository.GetProducts();
            orderDetails= (List<OrderDetail>) orderDetailRepository.GetOrderDetails();
            orderrs= (List<Orderr>) orderrRepository.GetOrderrs();
        }
        public void loadOverView()
        {
            var sum = orderDetails.Join(orderrstatic, x => x.OrderId, y => y.OrderId, (x, y) => new { x.Quantity, x.ProductId, x.Discount })
                    .GroupJoin(products, xx => xx.ProductId, yy => yy.ProductId, (xx, yy) => new { xx.Discount, xx.Quantity, yy.FirstOrDefault()?.UnitPrice });
                    
            txt_Total.Text = sum.Sum(x => (x.Quantity * x.UnitPrice * (1 -(decimal)x.Discount))).ToString();
            txt_NumOrder.Text = orderrstatic.Count.ToString();
            txt_NumProduct.Text = sum.Sum(x => (x.Quantity)).ToString();
        }
        private void frmStatistic_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            try
            {
                DateTime dateTimeFrom = dtp_From.Value;
                DateTime dateTimeTo = dtp_To.Value;
                orderrstatic= new List<Orderr>();
                bindingSource = new BindingSource();
                orderrstatic.AddRange(orderrs.Where(x => x.OrderDate > dateTimeFrom && x.OrderDate < dateTimeTo));
                bindingSource.DataSource = (IEnumerable<Orderr>) orderrstatic;
                dgv_Statistic.DataSource = bindingSource;
                dgv_Statistic.Columns[dgv_Statistic.ColumnCount-1].Visible = true;
                loadOverView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            loadOrderrs();
            orderrstatic = new List<Orderr>();
            orderrstatic.AddRange(orderrs);
            LoadDataGridView();
        }

        private void dtp_From_ValueChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void dtp_To_ValueChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void dgv_Statistic_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_Statistic.Rows[e.RowIndex];
                int orderID = Convert.ToInt32(selectedRow.Cells["OrderID"].Value.ToString());
                frmOrderDetail frm = new frmOrderDetail(orderrRepository.GetOrderrByID(orderID), true);
                frm.ShowDialog();
            }
           
        }
    }
}
