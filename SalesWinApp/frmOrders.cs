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
    public partial class frmOrders : Form
    {
        
        IOrderrRepository orderrRepository= new OrderrRepository();
        BindingSource bindingSource;
        int indexPage = 1;
        bool isAdmin;
        (string orderBy, bool ASC) sort;
        Member member;
        public frmOrders(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            sort.orderBy = "OrderDate";
            sort.ASC = true;
            loadDataGridView();
        }
        public frmOrders(Member member)
        {
            InitializeComponent();
            this.isAdmin = false;
            sort.orderBy = "OrderDate";
            sort.ASC = true;
            this.member = member;
            loadDataGridView();
        }
        private void frmOrderscs_Load(object sender, EventArgs e)
        {
            txt_OrderID.Enabled = false;
            txt_Frieght.Enabled = false;
            txt_MemberID.Enabled = false;
            dtp_OrderDate.Enabled = false;
            dtp_RequiredDate.Enabled = false;
            dtp_ShippedDate.Enabled = false;
            if(!isAdmin) btn_CancleOrder.Enabled = false;
        }
        public Orderr Get() => new Orderr()
        {
            OrderId = Convert.ToInt32(txt_OrderID.Text),
            Frieght = Convert.ToDecimal(txt_Frieght.Text),
            MemberId = Convert.ToInt32(txt_MemberID.Text),
            OrderDate = dtp_OrderDate.Value,
            RequiredDate = dtp_RequiredDate.Value,
            ShippedDate = dtp_ShippedDate.Value,
        };
        public void Clear()
        {
            txt_OrderID.Clear();
            txt_Frieght.Clear();
            txt_MemberID.Clear();
        }
        public void loadDataGridView()
        {
            try
            {
                lbl_index.Text = indexPage.ToString();
                bindingSource = new BindingSource();
                if (isAdmin)
                {
                    bindingSource.DataSource = orderrRepository.GetOrderrs(indexPage, sort);
                }
                else
                {
                    bindingSource.DataSource = orderrRepository.GetOrderrs(indexPage,member.MemberId, sort);
                }

                txt_Frieght.DataBindings.Clear();
                txt_MemberID.DataBindings.Clear();
                txt_OrderID.DataBindings.Clear();
                dtp_OrderDate.DataBindings.Clear();
                dtp_RequiredDate.DataBindings.Clear();
                dtp_ShippedDate.DataBindings.Clear();

                txt_Frieght.DataBindings.Add("Text", bindingSource, "Frieght");
                txt_MemberID.DataBindings.Add("Text", bindingSource, "MemberID");
                txt_OrderID.DataBindings.Add("Text", bindingSource, "OrderID");
                dtp_OrderDate.DataBindings.Add("Text", bindingSource, "OrderDate");
                dtp_RequiredDate.DataBindings.Add("Text", bindingSource, "RequiredDate");
                dtp_ShippedDate.DataBindings.Add("Text", bindingSource, "ShippedDate");

                dgv_Oder.DataSource= bindingSource;
                if (bindingSource.Count == 0)
                    btn_CancleOrder.Enabled = false;
                dgv_Oder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_Oder.Columns[dgv_Oder.ColumnCount-1].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (indexPage == 1) return;
            else --indexPage;
            loadDataGridView();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (indexPage == 10) return;
            else ++indexPage;
            loadDataGridView();
        }

        private void dgv_Oder_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = dgv_Oder.Columns[e.ColumnIndex];
            if (sort.orderBy.Equals(clickedColumn.Name)) sort.ASC = sort.ASC ? false : true;
            else sort.orderBy = clickedColumn.Name;
            loadDataGridView();
        }

        private void dgv_Oder_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmOrderDetail frm= new frmOrderDetail( Get(), isAdmin);
            frm.ShowDialog();
        }

        private void btn_CancleOrder_Click(object sender, EventArgs e)
        {
            Orderr orderr = Get();
            DialogResult result = MessageBox.Show($"Bạn có muốn xóa orderID {orderr.OrderId} này không ?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    orderrRepository.Delete(orderr.OrderId);
                    MessageBox.Show("!!!Đã xóa thành công!!!");
                    loadDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
