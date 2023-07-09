namespace SalesWinApp
{
    partial class frmProductDetail
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
            this.gbx_title = new System.Windows.Forms.GroupBox();
            this.cbb_Category = new System.Windows.Forms.ComboBox();
            this.txt_UnitslnStock = new System.Windows.Forms.TextBox();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.txt_Weight = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ProductID = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.btn_Action = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.gbx_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_title
            // 
            this.gbx_title.Controls.Add(this.txt_Quantity);
            this.gbx_title.Controls.Add(this.lbl_Quantity);
            this.gbx_title.Controls.Add(this.cbb_Category);
            this.gbx_title.Controls.Add(this.txt_UnitslnStock);
            this.gbx_title.Controls.Add(this.txt_UnitPrice);
            this.gbx_title.Controls.Add(this.txt_Weight);
            this.gbx_title.Controls.Add(this.txt_ProductName);
            this.gbx_title.Controls.Add(this.txt_ProductID);
            this.gbx_title.Controls.Add(this.label6);
            this.gbx_title.Controls.Add(this.label5);
            this.gbx_title.Controls.Add(this.label4);
            this.gbx_title.Controls.Add(this.label3);
            this.gbx_title.Controls.Add(this.label2);
            this.gbx_title.Controls.Add(this.lbl_ProductID);
            this.gbx_title.Location = new System.Drawing.Point(12, 34);
            this.gbx_title.Name = "gbx_title";
            this.gbx_title.Size = new System.Drawing.Size(348, 429);
            this.gbx_title.TabIndex = 0;
            this.gbx_title.TabStop = false;
            this.gbx_title.Text = "groupBox";
            // 
            // cbb_Category
            // 
            this.cbb_Category.FormattingEnabled = true;
            this.cbb_Category.Location = new System.Drawing.Point(125, 98);
            this.cbb_Category.Name = "cbb_Category";
            this.cbb_Category.Size = new System.Drawing.Size(203, 28);
            this.cbb_Category.TabIndex = 13;
            // 
            // txt_UnitslnStock
            // 
            this.txt_UnitslnStock.Location = new System.Drawing.Point(128, 337);
            this.txt_UnitslnStock.Name = "txt_UnitslnStock";
            this.txt_UnitslnStock.Size = new System.Drawing.Size(200, 27);
            this.txt_UnitslnStock.TabIndex = 12;
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Location = new System.Drawing.Point(128, 282);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(200, 27);
            this.txt_UnitPrice.TabIndex = 11;
            // 
            // txt_Weight
            // 
            this.txt_Weight.Location = new System.Drawing.Point(128, 216);
            this.txt_Weight.Name = "txt_Weight";
            this.txt_Weight.Size = new System.Drawing.Size(200, 27);
            this.txt_Weight.TabIndex = 10;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(125, 151);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(203, 27);
            this.txt_ProductName.TabIndex = 9;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.Location = new System.Drawing.Point(125, 31);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(203, 27);
            this.txt_ProductID.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "UnitslnStock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "UnitPrice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ProductName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // lbl_ProductID
            // 
            this.lbl_ProductID.AutoSize = true;
            this.lbl_ProductID.Location = new System.Drawing.Point(18, 38);
            this.lbl_ProductID.Name = "lbl_ProductID";
            this.lbl_ProductID.Size = new System.Drawing.Size(75, 20);
            this.lbl_ProductID.TabIndex = 1;
            this.lbl_ProductID.Text = "ProductID";
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btn_Action
            // 
            this.btn_Action.Location = new System.Drawing.Point(36, 469);
            this.btn_Action.Name = "btn_Action";
            this.btn_Action.Size = new System.Drawing.Size(94, 29);
            this.btn_Action.TabIndex = 14;
            this.btn_Action.Text = "Action";
            this.btn_Action.UseVisualStyleBackColor = true;
            this.btn_Action.Click += new System.EventHandler(this.btn_Action_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(224, 469);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(94, 29);
            this.btn_Close.TabIndex = 15;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Location = new System.Drawing.Point(18, 393);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(65, 20);
            this.lbl_Quantity.TabIndex = 14;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(128, 390);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(200, 27);
            this.txt_Quantity.TabIndex = 15;
            // 
            // frmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 510);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Action);
            this.Controls.Add(this.gbx_title);
            this.Name = "frmProductDetail";
            this.Text = "frmProductDetail";
            this.Load += new System.EventHandler(this.frmProductDetail_Load);
            this.gbx_title.ResumeLayout(false);
            this.gbx_title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbx_title;
        private TextBox txt_UnitslnStock;
        private TextBox txt_UnitPrice;
        private TextBox txt_Weight;
        private TextBox txt_ProductName;
        private TextBox txt_ProductID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbl_ProductID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cbb_Category;
        private Button btn_Action;
        private Button btn_Close;
        private TextBox txt_Quantity;
        private Label lbl_Quantity;
    }
}