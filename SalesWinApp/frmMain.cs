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
namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        List<OrderDetail> cart;
        private bool isAdmin;
        Member member;
        // none  : chua dang nhap
        // user  : da dang nhap nhung k fai la admin
        // admin : da dang nhap va la admin
        public frmMain(bool isAdmin)
        {
            this.IsMdiContainer = true;
            InitializeComponent();
            this.isAdmin = isAdmin;
            tsmi_Cart.Visible = false;
        }
        public frmMain(Member member)
        {
            this.IsMdiContainer = true;
            InitializeComponent();
            cart = new List<OrderDetail>();
            tsmi_Statistic.Visible = false;
            /*{
                new OrderDetail()
                {
                    OrderId= -1,
                    Discount= 0,
                    ProductId= 1,
                    Quantity=3,
                },
                new OrderDetail()
                {
                    OrderId= -1,
                    Discount= 0,
                    ProductId= 2,
                    Quantity=3,
                },
                new OrderDetail()
                {
                    OrderId= -1,
                    Discount= 0,
                    ProductId= 3,
                    Quantity=3,
                }
            };*/
            this.isAdmin = false;
            this.member = member;
            tsmi_Member.Text = "View Infor";
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                frmMembers frm = new frmMembers();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frmMemberDetail frm = new frmMemberDetail(member);
                frm.MdiParent = this;
                frm.Show();
            }
        }


        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts frm = isAdmin? new frmProducts(isAdmin): new frmProducts(member, cart);
            frm.MdiParent = this;
            frm.Show();
        }


        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory(isAdmin);
            frm.MdiParent = this;
            frm.Show();
        }

        private void orderrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                frmOrders frm = new frmOrders(true);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                frmOrders frm = new frmOrders(member);
                frm.MdiParent = this;
                frm.Show();
            }
            
        }

        private void tsmi_Cart_Click(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                frmCart frm = new frmCart(cart, member);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                frmStatistic frm = new frmStatistic();
                frm.MdiParent = this;
                frm.Show();
            }
        }

    }
}
