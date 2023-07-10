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
using System.Text.RegularExpressions;
namespace SalesWinApp
{
    public partial class frmMemberDetail : Form
    {
        BindingSource bindingSource;
        bool isInsert;
        IMemberRepository memberRepository= new MemberRepository();
        bool isAdmin;
        public frmMemberDetail(BindingSource bindingSource)
        {
            InitializeComponent();
            this.isInsert = true;
            txt_MemberID.Visible = false;
            lbl_ID.Visible = false;
            lbl_title.Text = "Member Insert";
            btn_Action.Text = "Insert";
            this.bindingSource = bindingSource;
            this.isAdmin = true;
        }
        public frmMemberDetail(Member member, BindingSource bindingSource)
        {
            InitializeComponent();
            Show(member);
            this.isInsert = false;
            txt_MemberID.Enabled = false;
            lbl_title.Text= "Member Update";
            btn_Action.Text = "Update";
            this.bindingSource = bindingSource;
            this.isAdmin = true;
        }
        public frmMemberDetail(Member member)
        {
            InitializeComponent();
            Show(member);
            this.isInsert = false;
            txt_MemberID.Enabled = false;
            lbl_title.Text = "Member Update";
            btn_Action.Text = "Update";
            this.isAdmin = false;
        }
        public void Show(Member member)
        {
            txt_MemberID.Text = member.MemberId.ToString();
            txt_Email.Text = member.Email;
            txt_CompanyName.Text = member.CompanyName;
            txt_City.Text = member.City;
            txt_Country.Text = member.Contry;
            txt_Password.Text = member.Password;
        }
        public bool CheckFillInput()
        {
            string str = "";
            if (txt_Email.Text == null || txt_Email.Text.Trim().Equals(""))
                str = str.Equals("") ? "Email" : ", Email";
            if (txt_CompanyName.Text == null || txt_CompanyName.Text.Trim().Equals(""))
                str = str.Equals("") ? "Company Name" : ", Company Name";
            if (txt_City.Text == null || txt_City.Text.Trim().Equals(""))
                str = str.Equals("") ? "City" : ", City";
            if (txt_Country.Text == null || txt_Country.Text.Trim().Equals(""))
                str = str.Equals("") ? "Country" : ", Country";
            if (txt_Password.Text == null || txt_Password.Text.Trim().Equals(""))
                str = str.Equals("") ? "Password" : ", Password";
            if(str.Equals("")) return true;
            MessageBox.Show(str+" Must be filled");
            return false;
        }
        public Member Get() => new Member() {
                                                MemberId= isInsert? 0: Convert.ToInt32(txt_MemberID.Text),
                                                Email = txt_Email.Text,
                                                CompanyName = txt_CompanyName.Text,
                                                City = txt_City.Text,
                                                Contry = txt_Country.Text,
                                                Password = txt_Password.Text
                                            };
        public void IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            if (!Regex.IsMatch(email, pattern))
                throw new Exception("Email format fail");
        }
        private void Insert(Member member)
        {
            try
            {
                memberRepository.Insert(member);
            }catch (Exception ex)
            {
                throw new Exception("Insert(): " + ex.Message);
            }
        }
        public void Modify(Member member)
        {
            try
            {
                memberRepository.Update(member);
            }
            catch (Exception ex)
            {
                throw new Exception("Update(): " + ex.Message);
            }
        }
        private void btn_Action_Click(object sender, EventArgs e)
        {
            if (!CheckFillInput()) return;
            Member member = Get();
            if (isAdmin) { 
                try
                {
                    IsValidEmail(member.Email);
                    if (isInsert)
                    {
                        Insert(member);
                        bindingSource.DataSource = memberRepository.GetMembers();
                        MessageBox.Show("!!!Insert successfull!!!\n" + member.ToString());
                    }
                    else
                    {
                        Modify(member);
                        bindingSource.DataSource = memberRepository.GetMembers();
                        MessageBox.Show("!!!Update successfull!!!\n" + member.ToString());
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    IsValidEmail(member.Email);
                    Modify(member);
                    MessageBox.Show("!!!Update successfull!!!\n" + member.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }



        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
