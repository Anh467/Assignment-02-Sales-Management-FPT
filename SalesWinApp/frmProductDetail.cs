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
    public partial class frmProductDetail : Form
    {
        IProductRepository productRepository= new ProductRepository();
        ICategoryRepository categoryRepository= new CategoryRepository();
        List<OrderDetail> cart;
        bool isAdmin;
        Member member;
        BindingSource bindingSource;
        bool isInsert;
        public frmProductDetail(BindingSource bindingSource, Product product)
        {
            InitializeComponent();
            this.bindingSource = bindingSource;
            this.isInsert = false;
            gbx_title.Text = "Update";
            this.Text = "Update Screen";
            txt_ProductID.ReadOnly = true;
            btn_Action.Text = "Update";
            Show(product);
            this.isAdmin = true;
        }
        public frmProductDetail(BindingSource bindingSource)
        {
            InitializeComponent();
            this.bindingSource = bindingSource;
            this.isInsert = true;
            gbx_title.Text = "Insert";
            this.Text = "Insert Screen";
            txt_ProductID.Visible = false;
            lbl_ProductID.Visible = false;
            btn_Action.Text = "Insert";
            cbb_Category.Items.AddRange(categoryRepository.GetCategories().ToArray());
            this.isAdmin = true;
        }
        public frmProductDetail(BindingSource bindingSource, Product product, List<OrderDetail> cart, Member member)
        {
            InitializeComponent();
            this.bindingSource = bindingSource;
            this.isInsert = false;
            gbx_title.Text = "Add to Cart";
            this.Text = "Add to Cart Screen";
            txt_ProductID.ReadOnly = true;
            btn_Action.Text = "Add to Cart";
            Show(product);
            cbb_Category.Enabled= false;
            this.isAdmin = false;
            this.member = member;
            this.cart = cart;
        }
        public Product Get() => new Product()
        {
            CategoryId =Convert.ToInt32(cbb_Category.Text.Substring(0, cbb_Category.Text.IndexOf('.'))),
            ProductId = isInsert ? 0 : Convert.ToInt32(txt_ProductID.Text),
            ProductName = txt_ProductName.Text,
            UnitPrice = Convert.ToDecimal(txt_UnitPrice.Text),
            UnitslnStock = Convert.ToInt32(txt_UnitslnStock.Text),
            Weight = txt_Weight.Text
        };
        public void Show(Product product)
        {
            txt_ProductID.Text = product.ProductId.ToString();
            txt_ProductName.Text = product.ProductName;
            txt_UnitPrice.Text = product.UnitPrice.ToString();
            txt_UnitslnStock.Text = product.UnitslnStock.ToString();
            txt_Weight.Text = product.Weight.ToString();
            cbb_Category.Items.AddRange(categoryRepository.GetCategories().ToArray());
            cbb_Category.Text = categoryRepository.GetCategory(product.CategoryId).ToString();
        }
        public void CheckFill()
        {
            string str = "";
            if (cbb_Category.SelectedIndex == -1)
                str = str == "" ? "Category" : str+ ", Category";
            /*if (txt_ProductID == null || txt_ProductID.Text.Trim()=="")
                str = str == "" ? "ProductID" : str + ", ProductID"; */
            if (txt_ProductName == null || txt_ProductName.Text.Trim() == "")
                str = str == "" ? "ProductName" : str + ", ProductName";
            if (txt_UnitPrice == null || txt_UnitPrice.Text.Trim() == "")
                str = str == "" ? "UnitPrice" : str + ", UnitPrice";
            if (txt_UnitslnStock == null || txt_UnitslnStock.Text.Trim() == "")
                str = str == "" ? "UnitslnStock" : str + ", UnitslnStock";
            if (txt_Weight == null || txt_Weight.Text.Trim() == "")
                str = str == "" ? "Weight" : str + ", Weight";
            if (str == "") return;
            else throw new Exception("!!!"+str+" must be filled!!!");
        }
        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                txt_Quantity.Visible= false;
                lbl_Quantity.Visible= false;
            }
            else
            {
                txt_ProductName.Enabled=false;
                txt_ProductID.Enabled=false;
                txt_UnitPrice.Enabled=false;
                txt_UnitslnStock.Enabled=false;
                txt_Weight.Enabled=false;
            }
        }
        private void Insert(Product product)
        {
            try
            {
                productRepository.Insert(product);
                bindingSource.DataSource = productRepository.GetProducts();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private void Update(Product product)
        {
            try
            {
                productRepository.Update(product);
                bindingSource.DataSource = productRepository.GetProducts();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btn_Action_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                try
                {
                    CheckFill();
                    Product product = Get();
                    if (isInsert)
                    {
                        Insert(product);
                    }
                    else
                    {
                        Update(product);
                    }
                    bindingSource.DataSource = productRepository.GetProducts();
                    MessageBox.Show("!!!" + (isInsert ? "Insert" : "Update") + "Successfull!!!");
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
                    OrderDetail detail = new OrderDetail()
                    {
                        OrderId = -1,
                        Discount = 0,
                        ProductId = Convert.ToInt32(txt_ProductID.Text),
                        UnitPrice = Convert.ToDecimal(txt_UnitPrice.Text),
                        Quantity = Convert.ToInt32(txt_Quantity.Text),

                    };
                    if (cart.Any(item => item.ProductId == detail.ProductId))
                    {
                        int index = cart.FindIndex(item => item.ProductId == detail.ProductId);
                        DialogResult result = MessageBox.Show($"Sản phẩm với ID là {detail.ProductId} bạn đã có sẵn trong { cart[index].Quantity} giỏi hàng bạn có muốn thêm số lượng {detail.Quantity} không?",
                                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            cart[index].Quantity = cart[index].Quantity + detail.Quantity;
                            MessageBox.Show("!!Thêm thành công!!!");
                        }

                    }
                    else
                    {
                        DialogResult result = MessageBox.Show($"bạn có muốn thêm {detail.Quantity} sản phẩm với ID là {detail.ProductId} vào giỏ hàng không?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            cart.Add(detail);
                            MessageBox.Show("!!Thêm thành công!!!");
                        }

                    }
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
