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
    public partial class frmOrderDetail : Form
    {
        BindingSource bindingSource;
        IOrderDetailRepository orderDetailRepository= new OrderDetailRepository();
        IMemberRepository memberRepository= new MemberRepository();
        IOrderrRepository orderrRepository = new OrderrRepository();
        bool isAdmin;
        public frmOrderDetail( Orderr orderr, bool isAdmin)
        {
            InitializeComponent();
            SetOder(orderr);
            SetMember(memberRepository.GetMemberByID(orderr.MemberId));
            loadDataGridView();
            this.isAdmin = isAdmin;
        }
        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            txt_OrderID.Enabled = false;
            if (isAdmin) txt_Frieght.Enabled = true;
            else
            {
                btn_Cancle.Enabled = false;
                btn_Require.Enabled = false;
                btn_Save.Enabled = false;
                btn_Ship.Enabled = false;
                txt_Frieght.Enabled = false;
            };
            //txt_Frieght.Enabled = false;
            txt_MemberID.Enabled = false;
            dtp_OrderDate.Enabled = false;
            dtp_RequiredDate.Enabled = false;
            dtp_ShippedDate.Enabled = false;
            txt_MemberID.Enabled = false;
            txt_Email.Enabled = false;  
            txt_Contry.Enabled = false;
            txt_City.Enabled = false;
            txt_CompanyName.Enabled = false;
            
        }
        public void SetOder(Orderr orderr)
        {
            txt_OrderID.Text= orderr.OrderId.ToString();
            txt_Frieght.Text= orderr.Frieght.ToString();
            dtp_OrderDate.Text= orderr.OrderDate.ToString();
            dtp_RequiredDate.Text= orderr.RequiredDate.ToString();
            dtp_ShippedDate.Text = orderr.ShippedDate.ToString();
        }
        public void SetMember(Member member)
        {
            txt_MemberID.Text= member.MemberId.ToString();
            txt_Email.Text = member.Email.ToString();
            txt_CompanyName.Text = member.CompanyName.ToString();
            txt_City.Text = member.City.ToString();
            txt_Contry.Text = member.Contry.ToString();
        }
        public void loadDataGridView()
        {
            try
            {
                bindingSource = new BindingSource();
                bindingSource.DataSource= orderDetailRepository.GetOrderDetailByID(Convert.ToInt32(txt_OrderID.Text));
                dgv_OrderDetail.DataSource = bindingSource;
                SetOder(orderrRepository.GetOrderrByID(Convert.ToInt32(txt_OrderID.Text)));
                dgv_OrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_OrderDetail.Columns[dgv_OrderDetail.ColumnCount - 1].Visible = false;
                dgv_OrderDetail.Columns[dgv_OrderDetail.ColumnCount - 2].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void btn_Ship_Click(object sender, EventArgs e)
        {
            try
            {
                Orderr order= orderrRepository.GetOrderrByID(Convert.ToInt32(txt_OrderID.Text));
                order.ShippedDate = DateTime.Now;
                orderrRepository.Update(order);
                loadDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message ,"error");
            }
        }

        private void btn_Require_Click(object sender, EventArgs e)
        {
            try
            {
                Orderr order = orderrRepository.GetOrderrByID(Convert.ToInt32(txt_OrderID.Text));
                order.RequiredDate = DateTime.Now;
                orderrRepository.Update(order);
                loadDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            try
            {
                Orderr order = orderrRepository.GetOrderrByID(Convert.ToInt32(txt_OrderID.Text));
                order.ShippedDate = DateTime.MinValue;
                order.RequiredDate  = DateTime.MinValue;
                orderrRepository.Update(order);
                loadDataGridView();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Orderr order = orderrRepository.GetOrderrByID(Convert.ToInt32(txt_OrderID.Text));
                order.Frieght= Convert.ToDecimal(txt_Frieght.Text); 
                orderrRepository.Update(order);
                loadDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
