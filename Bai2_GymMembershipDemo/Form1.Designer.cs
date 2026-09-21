namespace Bai2_GymMembershipDemo;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label lblHeader;
    private System.Windows.Forms.GroupBox grpThongTin;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label lblSDT;
    private System.Windows.Forms.TextBox txtSDT;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblNgaySinh;
    private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    private System.Windows.Forms.Label lblGoiTap;
    private System.Windows.Forms.ComboBox cboGoiTap;
    private System.Windows.Forms.Label lblSoBuoiTuan;
    private System.Windows.Forms.NumericUpDown numSoBuoiTuan;
    private System.Windows.Forms.Button btnDangKy;
    private System.Windows.Forms.Button btnNhapLai;
    private System.Windows.Forms.ToolTip toolTip1;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();

        lblHeader = new System.Windows.Forms.Label();
        grpThongTin = new System.Windows.Forms.GroupBox();
        lblHoTen = new System.Windows.Forms.Label();
        txtHoTen = new System.Windows.Forms.TextBox();
        lblSDT = new System.Windows.Forms.Label();
        txtSDT = new System.Windows.Forms.TextBox();
        lblEmail = new System.Windows.Forms.Label();
        txtEmail = new System.Windows.Forms.TextBox();
        lblNgaySinh = new System.Windows.Forms.Label();
        dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
        lblGoiTap = new System.Windows.Forms.Label();
        cboGoiTap = new System.Windows.Forms.ComboBox();
        lblSoBuoiTuan = new System.Windows.Forms.Label();
        numSoBuoiTuan = new System.Windows.Forms.NumericUpDown();
        btnDangKy = new System.Windows.Forms.Button();
        btnNhapLai = new System.Windows.Forms.Button();
        toolTip1 = new System.Windows.Forms.ToolTip(components);

        grpThongTin.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).BeginInit();
        SuspendLayout();

        // 
        // lblHeader
        // 
        lblHeader.BackColor = System.Drawing.Color.MidnightBlue;
        lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
        lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblHeader.ForeColor = System.Drawing.Color.White;
        lblHeader.Location = new System.Drawing.Point(0, 0);
        lblHeader.Name = "lblHeader";
        lblHeader.Size = new System.Drawing.Size(620, 60);
        lblHeader.TabIndex = 0;
        lblHeader.Text = "ĐĂNG KÝ HỘI VIÊN GYM FITLIFE";
        lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // 
        // grpThongTin
        // 
        grpThongTin.Controls.Add(lblHoTen);
        grpThongTin.Controls.Add(txtHoTen);
        grpThongTin.Controls.Add(lblSDT);
        grpThongTin.Controls.Add(txtSDT);
        grpThongTin.Controls.Add(lblEmail);
        grpThongTin.Controls.Add(txtEmail);
        grpThongTin.Controls.Add(lblNgaySinh);
        grpThongTin.Controls.Add(dtpNgaySinh);
        grpThongTin.Controls.Add(lblGoiTap);
        grpThongTin.Controls.Add(cboGoiTap);
        grpThongTin.Controls.Add(lblSoBuoiTuan);
        grpThongTin.Controls.Add(numSoBuoiTuan);
        grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        grpThongTin.Location = new System.Drawing.Point(30, 80);
        grpThongTin.Name = "grpThongTin";
        grpThongTin.Size = new System.Drawing.Size(560, 310);
        grpThongTin.TabIndex = 1;
        grpThongTin.TabStop = false;
        grpThongTin.Text = "Thông tin đăng ký hội viên";

        // 
        // lblHoTen
        // 
        lblHoTen.AutoSize = true;
        lblHoTen.Location = new System.Drawing.Point(30, 40);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new System.Drawing.Size(88, 23);
        lblHoTen.TabIndex = 0;
        lblHoTen.Text = "Họ và tên:";

        // 
        // txtHoTen
        // 
        txtHoTen.Location = new System.Drawing.Point(180, 37);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new System.Drawing.Size(340, 30);
        txtHoTen.TabIndex = 1;

        // 
        // lblSDT
        // 
        lblSDT.AutoSize = true;
        lblSDT.Location = new System.Drawing.Point(30, 85);
        lblSDT.Name = "lblSDT";
        lblSDT.Size = new System.Drawing.Size(115, 23);
        lblSDT.TabIndex = 2;
        lblSDT.Text = "Số điện thoại:";

        // 
        // txtSDT
        // 
        txtSDT.Location = new System.Drawing.Point(180, 82);
        txtSDT.Name = "txtSDT";
        txtSDT.Size = new System.Drawing.Size(340, 30);
        txtSDT.TabIndex = 3;

        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.Location = new System.Drawing.Point(30, 130);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new System.Drawing.Size(55, 23);
        lblEmail.TabIndex = 4;
        lblEmail.Text = "Email:";

        // 
        // txtEmail
        // 
        txtEmail.Location = new System.Drawing.Point(180, 127);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new System.Drawing.Size(340, 30);
        txtEmail.TabIndex = 5;

        // 
        // lblNgaySinh
        // 
        lblNgaySinh.AutoSize = true;
        lblNgaySinh.Location = new System.Drawing.Point(30, 175);
        lblNgaySinh.Name = "lblNgaySinh";
        lblNgaySinh.Size = new System.Drawing.Size(90, 23);
        lblNgaySinh.TabIndex = 6;
        lblNgaySinh.Text = "Ngày sinh:";

        // 
        // dtpNgaySinh
        // 
        dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
        dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpNgaySinh.Location = new System.Drawing.Point(180, 172);
        dtpNgaySinh.Name = "dtpNgaySinh";
        dtpNgaySinh.Size = new System.Drawing.Size(340, 30);
        dtpNgaySinh.TabIndex = 7;
        dtpNgaySinh.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);

        // 
        // lblGoiTap
        // 
        lblGoiTap.AutoSize = true;
        lblGoiTap.Location = new System.Drawing.Point(30, 220);
        lblGoiTap.Name = "lblGoiTap";
        lblGoiTap.Size = new System.Drawing.Size(70, 23);
        lblGoiTap.TabIndex = 8;
        lblGoiTap.Text = "Gói tập:";

        // 
        // cboGoiTap
        // 
        cboGoiTap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cboGoiTap.FormattingEnabled = true;
        cboGoiTap.Items.AddRange(new object[] {
            "Basic",
            "VIP",
            "Premium"
        });
        cboGoiTap.Location = new System.Drawing.Point(180, 217);
        cboGoiTap.Name = "cboGoiTap";
        cboGoiTap.Size = new System.Drawing.Size(340, 29);
        cboGoiTap.TabIndex = 9;

        // 
        // lblSoBuoiTuan
        // 
        lblSoBuoiTuan.AutoSize = true;
        lblSoBuoiTuan.Location = new System.Drawing.Point(30, 265);
        lblSoBuoiTuan.Name = "lblSoBuoiTuan";
        lblSoBuoiTuan.Size = new System.Drawing.Size(120, 23);
        lblSoBuoiTuan.TabIndex = 10;
        lblSoBuoiTuan.Text = "Số buổi / tuần:";

        // 
        // numSoBuoiTuan
        // 
        numSoBuoiTuan.Location = new System.Drawing.Point(180, 263);
        numSoBuoiTuan.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
        numSoBuoiTuan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numSoBuoiTuan.Name = "numSoBuoiTuan";
        numSoBuoiTuan.Size = new System.Drawing.Size(120, 30);
        numSoBuoiTuan.TabIndex = 11;
        numSoBuoiTuan.Value = new decimal(new int[] { 3, 0, 0, 0 });

        // 
        // btnDangKy
        // 
        btnDangKy.BackColor = System.Drawing.Color.MidnightBlue;
        btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
        btnDangKy.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        btnDangKy.ForeColor = System.Drawing.Color.White;
        btnDangKy.Location = new System.Drawing.Point(210, 410);
        btnDangKy.Name = "btnDangKy";
        btnDangKy.Size = new System.Drawing.Size(160, 42);
        btnDangKy.TabIndex = 2;
        btnDangKy.Text = "Đăng ký";
        btnDangKy.UseVisualStyleBackColor = false;
        btnDangKy.Click += btnDangKy_Click;

        // 
        // btnNhapLai
        // 
        btnNhapLai.BackColor = System.Drawing.Color.LightGray;
        btnNhapLai.Cursor = System.Windows.Forms.Cursors.Hand;
        btnNhapLai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        btnNhapLai.Location = new System.Drawing.Point(390, 410);
        btnNhapLai.Name = "btnNhapLai";
        btnNhapLai.Size = new System.Drawing.Size(130, 42);
        btnNhapLai.TabIndex = 3;
        btnNhapLai.Text = "Nhập lại";
        btnNhapLai.UseVisualStyleBackColor = true;
        btnNhapLai.Click += btnNhapLai_Click;

        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.GhostWhite;
        ClientSize = new System.Drawing.Size(620, 475);
        Controls.Add(btnNhapLai);
        Controls.Add(btnDangKy);
        Controls.Add(grpThongTin);
        Controls.Add(lblHeader);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Bài 2: Form đăng ký hội viên phòng Gym (ToolTip)";
        Load += Form1_Load;
        grpThongTin.ResumeLayout(false);
        grpThongTin.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).EndInit();
        ResumeLayout(false);
    }

    #endregion
}

