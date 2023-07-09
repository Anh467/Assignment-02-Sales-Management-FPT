namespace SalesWinApp
{
    partial class frmStatistic
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
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            this.dgv_Statistic = new System.Windows.Forms.DataGridView();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.From = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.txt_NumOrder = new System.Windows.Forms.TextBox();
            this.txt_NumProduct = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Statistic)).BeginInit();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandTimeout = 30;
            this.sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // dgv_Statistic
            // 
            this.dgv_Statistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Statistic.Location = new System.Drawing.Point(230, 77);
            this.dgv_Statistic.Name = "dgv_Statistic";
            this.dgv_Statistic.RowHeadersWidth = 51;
            this.dgv_Statistic.RowTemplate.Height = 29;
            this.dgv_Statistic.Size = new System.Drawing.Size(822, 443);
            this.dgv_Statistic.TabIndex = 0;
            // 
            // dtp_From
            // 
            this.dtp_From.Location = new System.Drawing.Point(241, 550);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(250, 27);
            this.dtp_From.TabIndex = 1;
            this.dtp_From.ValueChanged += new System.EventHandler(this.dtp_From_ValueChanged);
            // 
            // dtp_To
            // 
            this.dtp_To.Location = new System.Drawing.Point(613, 550);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(250, 27);
            this.dtp_To.TabIndex = 2;
            this.dtp_To.ValueChanged += new System.EventHandler(this.dtp_To_ValueChanged);
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(175, 555);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(43, 20);
            this.From.TabIndex = 3;
            this.From.Text = "From";
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(533, 555);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(23, 20);
            this.to.TabIndex = 4;
            this.to.Text = "to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Statistic for Admin";
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.btn_Load);
            this.GroupBox.Controls.Add(this.txt_NumOrder);
            this.GroupBox.Controls.Add(this.txt_NumProduct);
            this.GroupBox.Controls.Add(this.txt_Total);
            this.GroupBox.Controls.Add(this.label4);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Location = new System.Drawing.Point(12, 77);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(206, 294);
            this.GroupBox.TabIndex = 6;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Overview";
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(46, 250);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(94, 29);
            this.btn_Load.TabIndex = 7;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // txt_NumOrder
            // 
            this.txt_NumOrder.Location = new System.Drawing.Point(146, 85);
            this.txt_NumOrder.Name = "txt_NumOrder";
            this.txt_NumOrder.Size = new System.Drawing.Size(38, 27);
            this.txt_NumOrder.TabIndex = 6;
            // 
            // txt_NumProduct
            // 
            this.txt_NumProduct.Location = new System.Drawing.Point(146, 132);
            this.txt_NumProduct.Name = "txt_NumProduct";
            this.txt_NumProduct.Size = new System.Drawing.Size(38, 27);
            this.txt_NumProduct.TabIndex = 5;
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(75, 36);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(109, 27);
            this.txt_Total.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number Order:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number Product:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total:";
            // 
            // frmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 596);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.to);
            this.Controls.Add(this.From);
            this.Controls.Add(this.dtp_To);
            this.Controls.Add(this.dtp_From);
            this.Controls.Add(this.dgv_Statistic);
            this.Name = "frmStatistic";
            this.Text = "frmStatistic";
            this.Load += new System.EventHandler(this.frmStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Statistic)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private DataGridView dgv_Statistic;
        private DateTimePicker dtp_From;
        private DateTimePicker dtp_To;
        private Label From;
        private Label to;
        private Label label1;
        private GroupBox GroupBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_NumOrder;
        private TextBox txt_NumProduct;
        private TextBox txt_Total;
        private Button btn_Load;
    }
}