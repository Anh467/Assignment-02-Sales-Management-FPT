using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using DataAccess.Repository;
using BusinessObject.Models;
namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
            test();
        }
        public (string, string) GetAdminAccount()
        {
            IConfiguration config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json", true, true)
                                    .Build();
            String email = config["LoginString:email"];
            String password = config["LoginString:password"];
            return (email, password);
        }
        public (string, string) GetLoginCredetial()
        {
            string email= txt_email.Text;
            string password= txt_pass.Text;
            return (email, password);
        }
        public bool CheckIsAdmin((string email, string pass) AdminAccount, (string email, string pass) EnterCredentail)
        => ((AdminAccount.email == EnterCredentail.email) && (AdminAccount.pass == EnterCredentail.pass));
        public bool CheckFillInput()
        {
            string mess = "";
            if (txt_email.Text.Trim() == "" || txt_email.Text == null)
                mess = "Email";
            if (txt_pass.Text.Trim() == "" || txt_pass.Text == null)
                mess = mess == "" ? "Pass" : mess + " And " + "Pass";
            if (mess == "") return true;
            MessageBox.Show("!!!"+mess+ "must be fill!!!");
            return false;
        }
        public void test()
        {
            //txt_email.Text = "van123@gmail.com";
            //txt_pass.Text = "viet123";
            txt_email.Text = "admin@fstore.com";
           txt_pass.Text = "admin@@";
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!CheckFillInput()) return;
            var credential = GetLoginCredetial();
            if (CheckIsAdmin(GetAdminAccount(), credential)) { 
                this.Hide();
                new frmMain(true).ShowDialog();
                this.Show();
                MessageBox.Show("Logout!!!");
                return;
            }
            Member member = memberRepository.CheckExistAccount(credential.Item1, credential.Item2);
            if (member!=null)
            {
                this.Hide();
                new frmMain(member).ShowDialog();
                this.Show();
                MessageBox.Show("Logout!!!");
                return;
            }
            MessageBox.Show("!!!Credential that you enter didn't right!!!");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar= false;
        }

        private void btn_Show_MouseLeave(object sender, EventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
        }
    }
}
