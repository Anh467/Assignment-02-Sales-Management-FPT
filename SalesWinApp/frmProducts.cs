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
    public partial class frmProducts : Form
    {
        IProductRepository productRepository = new ProductRepository();
        BindingSource bindingSource;
        bool isAdmin;
        Member member;
        (int pageIndex, string orderBy, bool ASC) sort = (1, "ProductID", true);
        List<OrderDetail> cart;
        public frmProducts(bool isAdmin)
        {
            InitializeComponent();
            loadDataGridView();
            this.isAdmin = isAdmin;
        }
        public frmProducts(Member member, List<OrderDetail> cart)
        {
            InitializeComponent();
            loadDataGridView();
            this.isAdmin = false;
            this.member = member;
            this.cart = cart;
        }
        public Product Get() => new Product()
        {
            CategoryId = Convert.ToInt32(txt_CategoryID.Text),
            ProductId = Convert.ToInt32(txt_ProductID.Text),
            ProductName = txt_ProductName.Text,
            UnitPrice = Convert.ToDecimal(txt_UnitPrice.Text),
            UnitslnStock = Convert.ToInt32(txt_UnitslnStock.Text),
            Weight = txt_Weight.Text
        }; 
        public T getValue<T>(TextBox txt)
        {
            try
            {
                if(txt.Text.Trim()=="")
                    return (T)Convert.ChangeType("-1", typeof(T));
                T convertedValue = (T)Convert.ChangeType(txt.Text.Trim(), typeof(T));
                return convertedValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi chuyển đổi giá trị: " + ex.Message);
                return (T)Convert.ChangeType("-1", typeof(T));
            }
        }
        public (int ProductID, string ProductName,
            double PriceLower, double PriceUpper,
            double StockLower, double StockUpper) GetSearch()
        {
            (int ProductID, string ProductName,
            double PriceLower, double PriceUpper,
            double StockLower, double StockUpper) search;
            search.ProductID = getValue<int>(txt_Search_ProductID);
            search.ProductName = txt_Search_ProductName.Text.Trim();
            search.PriceLower = getValue<double>(txt_Search_Price_Lower);
            search.PriceUpper = getValue<double>(txt_Search_Price_Upper);
            search.StockLower = getValue<double>(txt_Search_Stock_Lower);
            search.StockUpper = getValue<double>(txt_Search_Stock_Upper);
            return search;
        }
        private void loadDataGridView()
        {
            try
            {
                lbl_index.Text = sort.pageIndex.ToString();
                bindingSource = new BindingSource();
                bindingSource.DataSource = productRepository.GetProducts(sort, GetSearch());

                txt_CategoryID.DataBindings.Clear();
                txt_ProductID.DataBindings.Clear();
                txt_ProductName.DataBindings.Clear();
                txt_UnitPrice.DataBindings.Clear();
                txt_UnitslnStock.DataBindings.Clear();
                txt_Weight.DataBindings.Clear();

                txt_CategoryID.DataBindings.Add("Text", bindingSource, "CategoryID");
                txt_ProductID.DataBindings.Add("Text", bindingSource, "ProductID");
                txt_ProductName.DataBindings.Add("Text", bindingSource, "ProductName");
                txt_UnitPrice.DataBindings.Add("Text", bindingSource, "UnitPrice");
                txt_UnitslnStock.DataBindings.Add("Text", bindingSource, "UnitslnStock");
                txt_Weight.DataBindings.Add("Text", bindingSource, "Weight");

                dgv_Product.DataSource = bindingSource;
                if (bindingSource.Count == 0)
                    btn_Delete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
            
        }

        private bool justEnterNumber(KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Oemcomma || e.KeyChar == (char)Keys.OemPeriod))
            {
                e.Handled = true;
                return false;
            }
            return true;   
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                btn_Delete.Enabled = false;
                btn_Insert.Enabled = false;
            }
            else
            {
                btn_Delete.Enabled = true;
                btn_Insert.Enabled = true;
            }
        }

        private void dgv_Product_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (isAdmin)
            {
                frmProductDetail productDetail = new frmProductDetail(bindingSource, Get());
                productDetail.ShowDialog();
            }
            else
            {
                frmProductDetail productDetail = new frmProductDetail(bindingSource, Get(), cart, member);
                productDetail.ShowDialog();
            }
            
        }


        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            frmProductDetail productDetail = new frmProductDetail(bindingSource);
            productDetail.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                productRepository.Delete(Get().ProductId);
                bindingSource.DataSource= productRepository.GetProducts();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            ++sort.pageIndex;
            loadDataGridView();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (sort.pageIndex == 1) return;
            else --sort.pageIndex;
            loadDataGridView();
        }

        private void dgv_Product_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn= dgv_Product.Columns[e.ColumnIndex];
            if (sort.orderBy.Equals(clickedColumn.Name)) sort.ASC = sort.ASC ? false : true;
            else sort.orderBy = clickedColumn.Name;
            loadDataGridView();
        }
        private void clearSearchProduct()
        {
            txt_Search_Price_Lower.Text = "";
            txt_Search_Price_Upper.Text = "";
            txt_Search_ProductID.Text = "";
            txt_Search_ProductName.Text = "";
            txt_Search_Stock_Lower.Text = "";
            txt_Search_Stock_Upper.Text = "";
        }
        private void btn_Clear_Click(object sender, EventArgs e) => clearSearchProduct();



        private void txt_Search_Price_Lower_KeyPress(object sender, KeyPressEventArgs e)
        =>justEnterNumber(e);
        
                

        private void txt_Search_Price_Upper_KeyPress(object sender, KeyPressEventArgs e)
        => justEnterNumber(e);


        private void txt_Search_Stock_Lower_KeyPress(object sender, KeyPressEventArgs e)
        => justEnterNumber(e);


        private void txt_Search_Stock_Upper_KeyPress(object sender, KeyPressEventArgs e)
        => justEnterNumber(e);

        private void txt_Search_ProductID_KeyPress(object sender, KeyPressEventArgs e)
        => justEnterNumber(e);

        private void txt_Search_ProductID_TextChanged(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void txt_Search_ProductName_TextChanged(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void txt_Search_Price_Lower_TextChanged(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void txt_Search_Stock_Lower_TextChanged(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void txt_Search_Price_Upper_TextChanged(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void txt_Search_Stock_Upper_TextChanged(object sender, EventArgs e)
        {
            loadDataGridView();
        }

    }
}
