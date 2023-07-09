namespace SalesWinApp
{
    partial class frmProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.txt_Weight = new System.Windows.Forms.TextBox();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.txt_CategoryID = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_UnitslnStock = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_index = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.gbx_Search = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_Search_ProductName = new System.Windows.Forms.TextBox();
            this.txt_Search_ProductID = new System.Windows.Forms.TextBox();
            this.txt_Search_Price_Upper = new System.Windows.Forms.TextBox();
            this.txt_Search_Stock_Upper = new System.Windows.Forms.TextBox();
            this.txt_Search_Stock_Lower = new System.Windows.Forms.TextBox();
            this.txt_Search_Price_Lower = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.upper = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ProductID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbx_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Product
            // 
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Location = new System.Drawing.Point(12, 296);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.RowHeadersWidth = 51;
            this.dgv_Product.RowTemplate.Height = 29;
            this.dgv_Product.Size = new System.Drawing.Size(776, 175);
            this.dgv_Product.TabIndex = 0;
            this.dgv_Product.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Product_CellMouseDoubleClick);
            this.dgv_Product.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Product_ColumnHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ProductID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "CategoryID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "UnitPrice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "ProductName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "UnitslnStock";
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.Location = new System.Drawing.Point(98, 30);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(125, 27);
            this.txt_ProductID.TabIndex = 7;
            // 
            // txt_Weight
            // 
            this.txt_Weight.Location = new System.Drawing.Point(97, 77);
            this.txt_Weight.Name = "txt_Weight";
            this.txt_Weight.Size = new System.Drawing.Size(125, 27);
            this.txt_Weight.TabIndex = 8;
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Location = new System.Drawing.Point(338, 77);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(125, 27);
            this.txt_UnitPrice.TabIndex = 9;
            // 
            // txt_CategoryID
            // 
            this.txt_CategoryID.Location = new System.Drawing.Point(338, 30);
            this.txt_CategoryID.Name = "txt_CategoryID";
            this.txt_CategoryID.Size = new System.Drawing.Size(125, 27);
            this.txt_CategoryID.TabIndex = 10;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(607, 30);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(153, 27);
            this.txt_ProductName.TabIndex = 11;
            // 
            // txt_UnitslnStock
            // 
            this.txt_UnitslnStock.Location = new System.Drawing.Point(607, 77);
            this.txt_UnitslnStock.Name = "txt_UnitslnStock";
            this.txt_UnitslnStock.Size = new System.Drawing.Size(153, 27);
            this.txt_UnitslnStock.TabIndex = 12;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(518, 20);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 29);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(170, 20);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(94, 29);
            this.btn_Insert.TabIndex = 14;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(649, 20);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(94, 29);
            this.btn_Close.TabIndex = 15;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ProductID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Weight);
            this.groupBox1.Controls.Add(this.txt_UnitslnStock);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_ProductName);
            this.groupBox1.Controls.Add(this.txt_CategoryID);
            this.groupBox1.Controls.Add(this.txt_UnitPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 125);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(43, 20);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(94, 29);
            this.btn_Load.TabIndex = 17;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_index);
            this.groupBox2.Controls.Add(this.btn_Next);
            this.groupBox2.Controls.Add(this.btn_Previous);
            this.groupBox2.Controls.Add(this.btn_Load);
            this.groupBox2.Controls.Add(this.btn_Insert);
            this.groupBox2.Controls.Add(this.btn_Close);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Location = new System.Drawing.Point(12, 477);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 55);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Button";
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.Location = new System.Drawing.Point(380, 24);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(45, 20);
            this.lbl_index.TabIndex = 20;
            this.lbl_index.Text = "index";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(446, 20);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(54, 29);
            this.btn_Next.TabIndex = 19;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(308, 20);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(54, 29);
            this.btn_Previous.TabIndex = 18;
            this.btn_Previous.Text = "<";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // gbx_Search
            // 
            this.gbx_Search.Controls.Add(this.btn_Clear);
            this.gbx_Search.Controls.Add(this.txt_Search_ProductName);
            this.gbx_Search.Controls.Add(this.txt_Search_ProductID);
            this.gbx_Search.Controls.Add(this.txt_Search_Price_Upper);
            this.gbx_Search.Controls.Add(this.txt_Search_Stock_Upper);
            this.gbx_Search.Controls.Add(this.txt_Search_Stock_Lower);
            this.gbx_Search.Controls.Add(this.txt_Search_Price_Lower);
            this.gbx_Search.Controls.Add(this.label12);
            this.gbx_Search.Controls.Add(this.label11);
            this.gbx_Search.Controls.Add(this.label7);
            this.gbx_Search.Controls.Add(this.upper);
            this.gbx_Search.Controls.Add(this.label10);
            this.gbx_Search.Controls.Add(this.label9);
            this.gbx_Search.Controls.Add(this.label8);
            this.gbx_Search.Controls.Add(this.ProductID);
            this.gbx_Search.Location = new System.Drawing.Point(12, 143);
            this.gbx_Search.Name = "gbx_Search";
            this.gbx_Search.Size = new System.Drawing.Size(776, 147);
            this.gbx_Search.TabIndex = 19;
            this.gbx_Search.TabStop = false;
            this.gbx_Search.Text = "Search Product";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(338, 112);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(94, 29);
            this.btn_Clear.TabIndex = 14;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_Search_ProductName
            // 
            this.txt_Search_ProductName.Location = new System.Drawing.Point(122, 76);
            this.txt_Search_ProductName.Name = "txt_Search_ProductName";
            this.txt_Search_ProductName.Size = new System.Drawing.Size(194, 27);
            this.txt_Search_ProductName.TabIndex = 13;
            this.txt_Search_ProductName.TextChanged += new System.EventHandler(this.txt_Search_ProductName_TextChanged);
            // 
            // txt_Search_ProductID
            // 
            this.txt_Search_ProductID.Location = new System.Drawing.Point(122, 30);
            this.txt_Search_ProductID.Name = "txt_Search_ProductID";
            this.txt_Search_ProductID.Size = new System.Drawing.Size(91, 27);
            this.txt_Search_ProductID.TabIndex = 12;
            this.txt_Search_ProductID.TextChanged += new System.EventHandler(this.txt_Search_ProductID_TextChanged);
            this.txt_Search_ProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_ProductID_KeyPress);
            // 
            // txt_Search_Price_Upper
            // 
            this.txt_Search_Price_Upper.Location = new System.Drawing.Point(649, 30);
            this.txt_Search_Price_Upper.Name = "txt_Search_Price_Upper";
            this.txt_Search_Price_Upper.Size = new System.Drawing.Size(91, 27);
            this.txt_Search_Price_Upper.TabIndex = 11;
            this.txt_Search_Price_Upper.TextChanged += new System.EventHandler(this.txt_Search_Price_Upper_TextChanged);
            this.txt_Search_Price_Upper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_Price_Upper_KeyPress);
            // 
            // txt_Search_Stock_Upper
            // 
            this.txt_Search_Stock_Upper.Location = new System.Drawing.Point(649, 76);
            this.txt_Search_Stock_Upper.Name = "txt_Search_Stock_Upper";
            this.txt_Search_Stock_Upper.Size = new System.Drawing.Size(91, 27);
            this.txt_Search_Stock_Upper.TabIndex = 10;
            this.txt_Search_Stock_Upper.TextChanged += new System.EventHandler(this.txt_Search_Stock_Upper_TextChanged);
            this.txt_Search_Stock_Upper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_Stock_Upper_KeyPress);
            // 
            // txt_Search_Stock_Lower
            // 
            this.txt_Search_Stock_Lower.Location = new System.Drawing.Point(497, 76);
            this.txt_Search_Stock_Lower.Name = "txt_Search_Stock_Lower";
            this.txt_Search_Stock_Lower.Size = new System.Drawing.Size(91, 27);
            this.txt_Search_Stock_Lower.TabIndex = 9;
            this.txt_Search_Stock_Lower.TextChanged += new System.EventHandler(this.txt_Search_Stock_Lower_TextChanged);
            this.txt_Search_Stock_Lower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_Stock_Lower_KeyPress);
            // 
            // txt_Search_Price_Lower
            // 
            this.txt_Search_Price_Lower.Location = new System.Drawing.Point(497, 30);
            this.txt_Search_Price_Lower.Name = "txt_Search_Price_Lower";
            this.txt_Search_Price_Lower.Size = new System.Drawing.Size(91, 27);
            this.txt_Search_Price_Lower.TabIndex = 8;
            this.txt_Search_Price_Lower.TextChanged += new System.EventHandler(this.txt_Search_Price_Lower_TextChanged);
            this.txt_Search_Price_Lower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_Price_Lower_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(595, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "upper";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(436, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "lower";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "lower";
            // 
            // upper
            // 
            this.upper.AutoSize = true;
            this.upper.Location = new System.Drawing.Point(595, 33);
            this.upper.Name = "upper";
            this.upper.Size = new System.Drawing.Size(48, 20);
            this.upper.TabIndex = 4;
            this.upper.Text = "upper";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(322, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "UnitStock:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "UnitPrice:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "ProductID";
            // 
            // ProductID
            // 
            this.ProductID.AutoSize = true;
            this.ProductID.Location = new System.Drawing.Point(17, 79);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(100, 20);
            this.ProductID.TabIndex = 0;
            this.ProductID.Text = "ProductName";
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.gbx_Search);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_Product);
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbx_Search.ResumeLayout(false);
            this.gbx_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_Product;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_ProductID;
        private TextBox txt_Weight;
        private TextBox txt_UnitPrice;
        private TextBox txt_CategoryID;
        private TextBox txt_ProductName;
        private TextBox txt_UnitslnStock;
        private Button btn_Delete;
        private Button btn_Insert;
        private Button btn_Close;
        private GroupBox groupBox1;
        private Button btn_Load;
        private GroupBox groupBox2;
        private Button btn_Next;
        private Button btn_Previous;
        private Label lbl_index;
        private GroupBox gbx_Search;
        private TextBox txt_Search_ProductName;
        private TextBox txt_Search_ProductID;
        private TextBox txt_Search_Price_Upper;
        private TextBox txt_Search_Stock_Upper;
        private TextBox txt_Search_Stock_Lower;
        private TextBox txt_Search_Price_Lower;
        private Label label12;
        private Label label11;
        private Label label7;
        private Label upper;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label ProductID;
        private Button btn_Clear;
    }
}