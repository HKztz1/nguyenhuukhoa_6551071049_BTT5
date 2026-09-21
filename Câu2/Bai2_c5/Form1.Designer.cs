namespace Bai2_c5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGoiTap = new System.Windows.Forms.Label();
            this.cboGoiTap = new System.Windows.Forms.ComboBox();
            this.lblSoBuoiTap = new System.Windows.Forms.Label();
            this.numSoBuoiTuan = new System.Windows.Forms.NumericUpDown();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numSoBuoiTuan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(165, 83);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(70, 16);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ và tên: ";
            this.lblHoTen.Click += new System.EventHandler(this.lblHoTen_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(296, 80);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 22);
            this.txtHoTen.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtHoTen, "Nhập đầy đủ họ và tên");
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(165, 124);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(88, 16);
            this.lblSDT.TabIndex = 2;
            this.lblSDT.Text = "Số điện thoại:";
            this.lblSDT.Click += new System.EventHandler(this.lblSDT_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(296, 124);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 22);
            this.txtSDT.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtSDT, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(165, 162);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(296, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(296, 202);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.TabIndex = 6;
            this.toolTip1.SetToolTip(this.dtpNgaySinh, "Chọn ngày tháng năm sinh");
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(165, 208);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(70, 16);
            this.lblNgaySinh.TabIndex = 7;
            this.lblNgaySinh.Text = "Ngày sinh:";
            this.lblNgaySinh.Click += new System.EventHandler(this.lblNgaySinh_Click);
            // 
            // lblGoiTap
            // 
            this.lblGoiTap.AutoSize = true;
            this.lblGoiTap.Location = new System.Drawing.Point(168, 255);
            this.lblGoiTap.Name = "lblGoiTap";
            this.lblGoiTap.Size = new System.Drawing.Size(53, 16);
            this.lblGoiTap.TabIndex = 8;
            this.lblGoiTap.Text = "Gói tập:";
            this.lblGoiTap.Click += new System.EventHandler(this.lblGoiTap_Click);
            // 
            // cboGoiTap
            // 
            this.cboGoiTap.FormattingEnabled = true;
            this.cboGoiTap.Items.AddRange(new object[] {
            "Basic",
            "VIP",
            "Premium"});
            this.cboGoiTap.Location = new System.Drawing.Point(296, 255);
            this.cboGoiTap.Name = "cboGoiTap";
            this.cboGoiTap.Size = new System.Drawing.Size(121, 24);
            this.cboGoiTap.TabIndex = 9;
            this.toolTip1.SetToolTip(this.cboGoiTap, "Gói VIP và Premium có kèm huấn luyện viên riêng");
            this.cboGoiTap.SelectedIndexChanged += new System.EventHandler(this.cboGoiTap_SelectedIndexChanged);
            // 
            // lblSoBuoiTap
            // 
            this.lblSoBuoiTap.AutoSize = true;
            this.lblSoBuoiTap.Location = new System.Drawing.Point(165, 304);
            this.lblSoBuoiTap.Name = "lblSoBuoiTap";
            this.lblSoBuoiTap.Size = new System.Drawing.Size(75, 16);
            this.lblSoBuoiTap.TabIndex = 10;
            this.lblSoBuoiTap.Text = "Số buổi tập";
            this.lblSoBuoiTap.Click += new System.EventHandler(this.lblSoBuoiTap_Click);
            // 
            // numSoBuoiTuan
            // 
            this.numSoBuoiTuan.Location = new System.Drawing.Point(296, 298);
            this.numSoBuoiTuan.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numSoBuoiTuan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoBuoiTuan.Name = "numSoBuoiTuan";
            this.numSoBuoiTuan.Size = new System.Drawing.Size(120, 22);
            this.numSoBuoiTuan.TabIndex = 11;
            this.toolTip1.SetToolTip(this.numSoBuoiTuan, "Số buổi tập muốn đăng kí trong tuần");
            this.numSoBuoiTuan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoBuoiTuan.ValueChanged += new System.EventHandler(this.numSoBuoiTuan_ValueChanged);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Location = new System.Drawing.Point(246, 383);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(75, 23);
            this.btnDangKi.TabIndex = 12;
            this.btnDangKi.Text = "Đăng ký";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.numSoBuoiTuan);
            this.Controls.Add(this.lblSoBuoiTap);
            this.Controls.Add(this.cboGoiTap);
            this.Controls.Add(this.lblGoiTap);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoBuoiTuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGoiTap;
        private System.Windows.Forms.ComboBox cboGoiTap;
        private System.Windows.Forms.Label lblSoBuoiTap;
        private System.Windows.Forms.NumericUpDown numSoBuoiTuan;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

