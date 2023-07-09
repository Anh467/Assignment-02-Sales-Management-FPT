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
    public partial class frmCart : Form
    {
        List<OrderDetail> cart;
        Member member;
        BindingSource bindingSource;    
        IOrderDetailRepository orderDetailRepository= new OrderDetailRepository();
        IOrderrRepository orderrRepository= new OrderrRepository(); 
        IProductRepository productRepository= new ProductRepository();
        public frmCart(List<OrderDetail> cart, Member member)
        {
            InitializeComponent();
            this.cart = cart;
            this.member = member;
            loadDataGridView();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            txt_MemberID.ReadOnly = false;
            txt_MemberID.Text= member.MemberId.ToString();
        }
        public void loadDataGridView()
        {
            try
            {
                bindingSource = new BindingSource();
                bindingSource.DataSource = cart;
                
                
                txt_ProductID.DataBindings.Clear(); 
                txt_Quantity.DataBindings.Clear();
                txt_UnitPrice.DataBindings.Clear();

                txt_ProductID.DataBindings.Add("Text", bindingSource, "ProductID");
                txt_Quantity.DataBindings.Add("Text", bindingSource, "Quantity");
                txt_UnitPrice.DataBindings.Add("Text", bindingSource, "UnitPrice");

                dgv_Cart.DataSource = bindingSource;
                dgv_Cart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_Cart.Columns[dgv_Cart.ColumnCount - 1].Visible = false;
                dgv_Cart.Columns[dgv_Cart.ColumnCount - 2].Visible = false;
                dgv_Cart.Columns[0].Visible = false;

                decimal total = cart.Sum(x=>x.UnitPrice * x.Quantity);
                lbl_Total.Text = "Total: " + total;
                if(cart.Count == 0)
                {
                    btn_DeleteAll.Enabled = false;
                    button1.Enabled = false;
                }
                else
                {
                    btn_DeleteAll.Enabled = true;
                    button1.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int productID= Convert.ToInt32(txt_ProductID.Text);
            try
            {
                cart.RemoveAll(x=> x.ProductId==productID);
                loadDataGridView(); 
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool checkQuantityStock()
        {
            string str = "";
            for(int i = 0; i < cart.Count; i++)
            {
                Product product = productRepository.GetProductsByID(cart[i].ProductId);
                if (cart[i].Quantity > product.UnitslnStock)
                    str = $"ProductID {product.ProductId}: not engouh for you request in warehouse is {product.UnitslnStock} and your request is {cart[i].Quantity}\n";
            }
            if(str=="") return true;
            MessageBox.Show(str);
            return false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!checkQuantityStock()) return;
            DialogResult result = MessageBox.Show("Bạn có muốn chấp nhận thêm hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Orderr orderr = new Orderr()
            {
                MemberId = member.MemberId,
                OrderDate = DateTime.Now,
                RequiredDate = DateTime.Now,
                ShippedDate = DateTime.Now,
                Frieght = 0,
            };
            if (result == DialogResult.Yes)
            {
                try
                {
                    int OrderID = orderrRepository.Insert(orderr);
                    foreach(OrderDetail orderDetail in cart)
                    {
                        orderDetail.Discount = 0;
                        orderDetail.OrderId = OrderID;
                        orderDetailRepository.Insert(orderDetail);
                    }
                    MessageBox.Show("!!!Thêm thành công!!!");
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void dgv_Cart_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Product product = new ProductRepository().GetProductsByID(Convert.ToInt32(txt_ProductID.Text));
            frmProductDetail productDetail = new frmProductDetail(bindingSource, product, cart, member);
            productDetail.ShowDialog();
        }

        private void btn_DeleteAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa toàn bộ giỏ hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                cart.RemoveAll(x=> true);
                loadDataGridView(); 
            }
        }
    }
}
