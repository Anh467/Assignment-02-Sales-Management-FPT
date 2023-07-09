namespace SalesWinApp
{
    partial class frmOrderDetail
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Require = new System.Windows.Forms.Button();
            this.btn_Ship = new System.Windows.Forms.Button();
            this.dgv_OrderDetail = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.GroupBox();
            this.dtp_ShippedDate = new System.Windows.Forms.DateTimePicker();
            this.txt_OrderID = new System.Windows.Forms.TextBox();
            this.dtp_RequiredDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_OrderDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Frieght = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Contry = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_CompanyName = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_MemberID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.GroupBox();
            this.btn_Cancle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetail)).BeginInit();
            this.Order.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Button.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(632, 26);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(94, 29);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Require
            // 
            this.btn_Require.Location = new System.Drawing.Point(322, 26);
            this.btn_Require.Name = "btn_Require";
            this.btn_Require.Size = new System.Drawing.Size(94, 29);
            this.btn_Require.TabIndex = 1;
            this.btn_Require.Text = "Require";
            this.btn_Require.UseVisualStyleBackColor = true;
            this.btn_Require.Click += new System.EventHandler(this.btn_Require_Click);
            // 
            // btn_Ship
            // 
            this.btn_Ship.Location = new System.Drawing.Point(179, 26);
            this.btn_Ship.Name = "btn_Ship";
            this.btn_Ship.Size = new System.Drawing.Size(94, 29);
            this.btn_Ship.TabIndex = 2;
            this.btn_Ship.Text = "Ship";
            this.btn_Ship.UseVisualStyleBackColor = true;
            this.btn_Ship.Click += new System.EventHandler(this.btn_Ship_Click);
            // 
            // dgv_OrderDetail
            // 
            this.dgv_OrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderDetail.Location = new System.Drawing.Point(9, 356);
            this.dgv_OrderDetail.Name = "dgv_OrderDetail";
            this.dgv_OrderDetail.RowHeadersWidth = 51;
            this.dgv_OrderDetail.RowTemplate.Height = 29;
            this.dgv_OrderDetail.Size = new System.Drawing.Size(776, 188);
            this.dgv_OrderDetail.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(37, 26);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 29);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Order
            // 
            this.Order.Controls.Add(this.dtp_ShippedDate);
            this.Order.Controls.Add(this.txt_OrderID);
            this.Order.Controls.Add(this.dtp_RequiredDate);
            this.Order.Controls.Add(this.label1);
            this.Order.Controls.Add(this.dtp_OrderDate);
            this.Order.Controls.Add(this.label2);
            this.Order.Controls.Add(this.txt_Frieght);
            this.Order.Controls.Add(this.label4);
            this.Order.Controls.Add(this.label5);
            this.Order.Controls.Add(this.label6);
            this.Order.Location = new System.Drawing.Point(12, 12);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(381, 316);
            this.Order.TabIndex = 5;
            this.Order.TabStop = false;
            this.Order.Text = "Order";
            // 
            // dtp_ShippedDate
            // 
            this.dtp_ShippedDate.Location = new System.Drawing.Point(124, 160);
            this.dtp_ShippedDate.Name = "dtp_ShippedDate";
            this.dtp_ShippedDate.Size = new System.Drawing.Size(250, 27);
            this.dtp_ShippedDate.TabIndex = 32;
            // 
            // txt_OrderID
            // 
            this.txt_OrderID.Location = new System.Drawing.Point(124, 59);
            this.txt_OrderID.Name = "txt_OrderID";
            this.txt_OrderID.Size = new System.Drawing.Size(125, 27);
            this.txt_OrderID.TabIndex = 27;
            // 
            // dtp_RequiredDate
            // 
            this.dtp_RequiredDate.Location = new System.Drawing.Point(124, 209);
            this.dtp_RequiredDate.Name = "dtp_RequiredDate";
            this.dtp_RequiredDate.Size = new System.Drawing.Size(250, 27);
            this.dtp_RequiredDate.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "OrderID";
            // 
            // dtp_OrderDate
            // 
            this.dtp_OrderDate.Location = new System.Drawing.Point(124, 110);
            this.dtp_OrderDate.Name = "dtp_OrderDate";
            this.dtp_OrderDate.Size = new System.Drawing.Size(250, 27);
            this.dtp_OrderDate.TabIndex = 30;
            this.dtp_OrderDate.Value = new System.DateTime(2023, 7, 6, 10, 46, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "RequiredDate";
            // 
            // txt_Frieght
            // 
            this.txt_Frieght.Location = new System.Drawing.Point(124, 261);
            this.txt_Frieght.Name = "txt_Frieght";
            this.txt_Frieght.Size = new System.Drawing.Size(125, 27);
            this.txt_Frieght.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "ShippedDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "OrderDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Frieght";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Contry);
            this.groupBox1.Controls.Add(this.txt_City);
            this.groupBox1.Controls.Add(this.txt_CompanyName);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_MemberID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(410, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 316);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member";
            // 
            // txt_Contry
            // 
            this.txt_Contry.Location = new System.Drawing.Point(159, 253);
            this.txt_Contry.Name = "txt_Contry";
            this.txt_Contry.Size = new System.Drawing.Size(181, 27);
            this.txt_Contry.TabIndex = 9;
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(160, 206);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(180, 27);
            this.txt_City.TabIndex = 8;
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Location = new System.Drawing.Point(159, 162);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(181, 27);
            this.txt_CompanyName.TabIndex = 7;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(160, 112);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(180, 27);
            this.txt_Email.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Contry";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "CompanyName";
            // 
            // txt_MemberID
            // 
            this.txt_MemberID.Location = new System.Drawing.Point(160, 59);
            this.txt_MemberID.Name = "txt_MemberID";
            this.txt_MemberID.Size = new System.Drawing.Size(180, 27);
            this.txt_MemberID.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "MemberID";
            // 
            // Button
            // 
            this.Button.Controls.Add(this.btn_Cancle);
            this.Button.Controls.Add(this.btn_Close);
            this.Button.Controls.Add(this.btn_Require);
            this.Button.Controls.Add(this.btn_Ship);
            this.Button.Controls.Add(this.btn_Save);
            this.Button.Location = new System.Drawing.Point(12, 550);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(773, 69);
            this.Button.TabIndex = 7;
            this.Button.TabStop = false;
            this.Button.Text = "Button";
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.Location = new System.Drawing.Point(484, 26);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(94, 29);
            this.btn_Cancle.TabIndex = 5;
            this.btn_Cancle.Text = "Cancle";
            this.btn_Cancle.UseVisualStyleBackColor = true;
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // frmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.dgv_OrderDetail);
            this.Name = "frmOrderDetail";
            this.Text = "frmOrderDetail";
            this.Load += new System.EventHandler(this.frmOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetail)).EndInit();
            this.Order.ResumeLayout(false);
            this.Order.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Close;
        private Button btn_Require;
        private Button btn_Ship;
        private DataGridView dgv_OrderDetail;
        private Button btn_Save;
        private GroupBox Order;
        private GroupBox groupBox1;
        private DateTimePicker dtp_ShippedDate;
        private TextBox txt_OrderID;
        private DateTimePicker dtp_RequiredDate;
        private Label label1;
        private DateTimePicker dtp_OrderDate;
        private Label label2;
        private TextBox txt_Frieght;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_Contry;
        private TextBox txt_City;
        private TextBox txt_CompanyName;
        private TextBox txt_Email;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txt_MemberID;
        private Label label8;
        private Label label7;
        private GroupBox Button;
        private Button btn_Cancle;
    }
}