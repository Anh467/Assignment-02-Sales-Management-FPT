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
    public partial class frmCategory : Form
    {
        ICategoryRepository categoryRepository= new CategoryRepository();
        BindingSource bindingSource;
        bool isAdmin;
        public frmCategory(bool isAdmin)
        {
            InitializeComponent();
            txt_CategoryID.ReadOnly = true;
            loadDataGridView();
            this.isAdmin = isAdmin;
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                btn_Create.Enabled = false;
                btn_Delete.Enabled = false;
                btn_Update.Enabled = false; 
            }
        }
        public Category Get()=> new Category()
        {
            CategoryId = Convert.ToInt32(txt_CategoryID.Text),
            CategoryName = txt_CategoryName.Text,   
        };
        public void Clear()
        {
            txt_CategoryID.Clear();
            txt_CategoryName.Clear();
        }
        public void CheckFill()
        {
            string str = "";
            if (txt_CategoryName.Text == "")
                str = "CategoryName";
            if(str!="")
            throw new Exception("!!!"+str+"Must be filled!!!");
        }
        private void loadDataGridView()
        {
            try
            {
                bindingSource = new BindingSource();
                bindingSource.DataSource = categoryRepository.GetCategories();

                txt_CategoryID.DataBindings.Clear();
                txt_CategoryName.DataBindings.Clear();

                txt_CategoryID.DataBindings.Add("Text", bindingSource, "CategoryID");
                txt_CategoryName.DataBindings.Add("Text", bindingSource, "CategoryName");

                dgv_Category.DataSource = bindingSource;
                if (bindingSource.Count == 0)
                    btn_Delete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                CheckFill();
                categoryRepository.Insert(Get());
                bindingSource.DataSource = categoryRepository.GetCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                CheckFill();
                categoryRepository.Delete(Get().CategoryId);
                bindingSource.DataSource = categoryRepository.GetCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                CheckFill();
                categoryRepository.Update(Get());
                bindingSource.DataSource = categoryRepository.GetCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
