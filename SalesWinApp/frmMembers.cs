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
    public partial class frmMembers : Form
    {
        IMemberRepository member= new MemberRepository();
        BindingSource bindingSource;
        public frmMembers()
        {
            
            InitializeComponent();
            loadDataGridView();
        }
        public void Clear()
        {
            txt_City.Text = string.Empty;
            txt_Country.Text = string.Empty;
            txt_CompanyName.Text = string.Empty;
            txt_Email.Text = string.Empty;  
            txt_MemberID.Text = string.Empty;
            txt_Password.Text = string.Empty;
        }
        public Member Get() => new Member()
        {
            MemberId = Convert.ToInt32(txt_MemberID.Text),
            Email = txt_Email.Text,
            CompanyName = txt_CompanyName.Text,
            City = txt_City.Text,
            Contry = txt_Country.Text,
            Password = txt_Password.Text
        };
        public void loadDataGridView()
        {
            try
            {
                bindingSource = new BindingSource();
                bindingSource.DataSource = member.GetMembers();
                dgv_members.DataSource = bindingSource.DataSource;
                //clear
                txt_MemberID.DataBindings.Clear();
                txt_City.DataBindings.Clear();
                txt_CompanyName.DataBindings.Clear();   
                txt_Country.DataBindings.Clear();
                txt_Email.DataBindings.Clear();
                txt_Password.DataBindings.Clear();

                // connect with bindingsourc
                txt_MemberID.DataBindings.Add("Text", bindingSource, "MemberID");
                txt_Email.DataBindings.Add("Text", bindingSource, "Email");
                txt_CompanyName.DataBindings.Add("Text", bindingSource, "CompanyName");
                txt_City.DataBindings.Add("Text", bindingSource, "City");
                txt_Country.DataBindings.Add("Text", bindingSource, "Contry");
                txt_Password.DataBindings.Add("Text", bindingSource, "Password");


                dgv_members.DataSource = bindingSource;
                if (bindingSource.Count ==0)
                    btn_Delete.Enabled = false;
                dgv_members.Columns[dgv_members.ColumnCount - 1].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("loadDataGridView(): "+ex.Message);
            }
        }

        private void dgv_members_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmMemberDetail frmCarDetails = new frmMemberDetail(Get(), bindingSource);
            frmCarDetails.ShowDialog();
        }
        private void btn_Create_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmCarDetails = new frmMemberDetail(bindingSource);
            frmCarDetails.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int memberID= Get().MemberId;
                member.Delete(memberID);
                Clear();
                bindingSource.DataSource = member.GetMembers();
            }catch(Exception ex)
            {
                MessageBox.Show("btn_Delete_Click(object sender, EventArgs e)\n"+ex.Message);
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            loadDataGridView();
        }

    }
}
