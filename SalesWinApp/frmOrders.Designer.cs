namespace SalesWinApp
{
    partial class frmOrders
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
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_CancleOrder = new System.Windows.Forms.Button();
            this.lbl_index = new System.Windows.Forms.Label();
            this.dgv_Oder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_OrderID = new System.Windows.Forms.TextBox();
            this.txt_MemberID = new System.Windows.Forms.TextBox();
            this.txt_Frieght = new System.Windows.Forms.TextBox();
            this.dtp_OrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_RequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_ShippedDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Oder)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(307, 26);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(48, 29);
            this.btn_Previous.TabIndex = 0;
            this.btn_Previous.Text = "<";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(417, 26);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(48, 29);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Close);
            this.groupBox1.Controls.Add(this.btn_Load);
            this.groupBox1.Controls.Add(this.btn_CancleOrder);
            this.groupBox1.Controls.Add(this.lbl_index);
            this.groupBox1.Controls.Add(this.btn_Previous);
            this.groupBox1.Controls.Add(this.btn_Next);
            this.groupBox1.Location = new System.Drawing.Point(13, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 102);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "button";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(626, 67);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(94, 29);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(341, 67);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(94, 29);
            this.btn_Load.TabIndex = 6;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_CancleOrder
            // 
            this.btn_CancleOrder.Location = new System.Drawing.Point(49, 67);
            this.btn_CancleOrder.Name = "btn_CancleOrder";
            this.btn_CancleOrder.Size = new System.Drawing.Size(105, 29);
            this.btn_CancleOrder.TabIndex = 5;
            this.btn_CancleOrder.Text = "Cancel Order";
            this.btn_CancleOrder.UseVisualStyleBackColor = true;
            this.btn_CancleOrder.Click += new System.EventHandler(this.btn_CancleOrder_Click);
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.Location = new System.Drawing.Point(361, 30);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(45, 20);
            this.lbl_index.TabIndex = 4;
            this.lbl_index.Text = "index";
            // 
            // dgv_Oder
            // 
            this.dgv_Oder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Oder.Location = new System.Drawing.Point(26, 162);
            this.dgv_Oder.Name = "dgv_Oder";
            this.dgv_Oder.RowHeadersWidth = 51;
            this.dgv_Oder.RowTemplate.Height = 29;
            this.dgv_Oder.Size = new System.Drawing.Size(750, 218);
            this.dgv_Oder.TabIndex = 5;
            this.dgv_Oder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_Oder.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Oder_CellMouseDoubleClick);
            this.dgv_Oder.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Oder_ColumnHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "OrderID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "RequiredDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "MemberID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ShippedDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "OrderDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Frieght";
            // 
            // txt_OrderID
            // 
            this.txt_OrderID.Location = new System.Drawing.Point(140, 15);
            this.txt_OrderID.Name = "txt_OrderID";
            this.txt_OrderID.Size = new System.Drawing.Size(125, 27);
            this.txt_OrderID.TabIndex = 12;
            // 
            // txt_MemberID
            // 
            this.txt_MemberID.Location = new System.Drawing.Point(514, 15);
            this.txt_MemberID.Name = "txt_MemberID";
            this.txt_MemberID.Size = new System.Drawing.Size(125, 27);
            this.txt_MemberID.TabIndex = 13;
            // 
            // txt_Frieght
            // 
            this.txt_Frieght.Location = new System.Drawing.Point(514, 114);
            this.txt_Frieght.Name = "txt_Frieght";
            this.txt_Frieght.Size = new System.Drawing.Size(125, 27);
            this.txt_Frieght.TabIndex = 17;
            // 
            // dtp_OrderDate
            // 
            this.dtp_OrderDate.Location = new System.Drawing.Point(140, 66);
            this.dtp_OrderDate.Name = "dtp_OrderDate";
            this.dtp_OrderDate.Size = new System.Drawing.Size(250, 27);
            this.dtp_OrderDate.TabIndex = 18;
            this.dtp_OrderDate.Value = new System.DateTime(2023, 7, 6, 10, 46, 0, 0);
            // 
            // dtp_RequiredDate
            // 
            this.dtp_RequiredDate.Location = new System.Drawing.Point(514, 66);
            this.dtp_RequiredDate.Name = "dtp_RequiredDate";
            this.dtp_RequiredDate.Size = new System.Drawing.Size(250, 27);
            this.dtp_RequiredDate.TabIndex = 19;
            // 
            // dtp_ShippedDate
            // 
            this.dtp_ShippedDate.Location = new System.Drawing.Point(140, 116);
            this.dtp_ShippedDate.Name = "dtp_ShippedDate";
            this.dtp_ShippedDate.Size = new System.Drawing.Size(250, 27);
            this.dtp_ShippedDate.TabIndex = 20;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.dtp_ShippedDate);
            this.Controls.Add(this.dtp_RequiredDate);
            this.Controls.Add(this.dtp_OrderDate);
            this.Controls.Add(this.txt_Frieght);
            this.Controls.Add(this.txt_MemberID);
            this.Controls.Add(this.txt_OrderID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Oder);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOrders";
            this.Text = "frmOrderscs";
            this.Load += new System.EventHandler(this.frmOrderscs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Oder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Previous;
        private Button btn_Next;
        private GroupBox groupBox1;
        private Button btn_Close;
        private Button btn_Load;
        private Label lbl_index;
        private DataGridView dgv_Oder;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_OrderID;
        private TextBox txt_MemberID;
        private TextBox txt_Frieght;
        private DateTimePicker dtp_OrderDate;
        private DateTimePicker dtp_RequiredDate;
        private DateTimePicker dtp_ShippedDate;
        private Button btn_CancleOrder;
    }
}