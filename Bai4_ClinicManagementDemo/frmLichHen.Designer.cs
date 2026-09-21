namespace Bai4_ClinicManagementDemo;

partial class frmLichHen
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label lblTenBenhNhan;
    private System.Windows.Forms.TextBox txtTenBenhNhan;
    private System.Windows.Forms.Label lblNgayHen;
    private System.Windows.Forms.DateTimePicker dtpNgayHen;
    private System.Windows.Forms.Button btnDatLich;
    private System.Windows.Forms.Label lblDanhSach;
    private System.Windows.Forms.ListBox lstLichHen;

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
        lblTenBenhNhan = new System.Windows.Forms.Label();
        txtTenBenhNhan = new System.Windows.Forms.TextBox();
        lblNgayHen = new System.Windows.Forms.Label();
        dtpNgayHen = new System.Windows.Forms.DateTimePicker();
        btnDatLich = new System.Windows.Forms.Button();
        lblDanhSach = new System.Windows.Forms.Label();
        lstLichHen = new System.Windows.Forms.ListBox();
        SuspendLayout();
        // 
        // lblTenBenhNhan
        // 
        lblTenBenhNhan.AutoSize = true;
        lblTenBenhNhan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblTenBenhNhan.Location = new System.Drawing.Point(20, 20);
        lblTenBenhNhan.Name = "lblTenBenhNhan";
        lblTenBenhNhan.Size = new System.Drawing.Size(113, 21);
        lblTenBenhNhan.TabIndex = 0;
        lblTenBenhNhan.Text = "Tên bệnh nhân:";
        // 
        // txtTenBenhNhan
        // 
        txtTenBenhNhan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        txtTenBenhNhan.Location = new System.Drawing.Point(145, 17);
        txtTenBenhNhan.Name = "txtTenBenhNhan";
        txtTenBenhNhan.Size = new System.Drawing.Size(295, 29);
        txtTenBenhNhan.TabIndex = 1;
        // 
        // lblNgayHen
        // 
        lblNgayHen.AutoSize = true;
        lblNgayHen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblNgayHen.Location = new System.Drawing.Point(20, 60);
        lblNgayHen.Name = "lblNgayHen";
        lblNgayHen.Size = new System.Drawing.Size(107, 21);
        lblNgayHen.TabIndex = 2;
        lblNgayHen.Text = "Ngày giờ hẹn:";
        // 
        // dtpNgayHen
        // 
        dtpNgayHen.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpNgayHen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        dtpNgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        dtpNgayHen.Location = new System.Drawing.Point(145, 57);
        dtpNgayHen.Name = "dtpNgayHen";
        dtpNgayHen.Size = new System.Drawing.Size(295, 29);
        dtpNgayHen.TabIndex = 3;
        // 
        // btnDatLich
        // 
        btnDatLich.BackColor = System.Drawing.Color.RoyalBlue;
        btnDatLich.Cursor = System.Windows.Forms.Cursors.Hand;
        btnDatLich.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        btnDatLich.ForeColor = System.Drawing.Color.White;
        btnDatLich.Location = new System.Drawing.Point(145, 100);
        btnDatLich.Name = "btnDatLich";
        btnDatLich.Size = new System.Drawing.Size(120, 35);
        btnDatLich.TabIndex = 4;
        btnDatLich.Text = "Đặt lịch";
        btnDatLich.UseVisualStyleBackColor = false;
        btnDatLich.Click += btnDatLich_Click;
        // 
        // lblDanhSach
        // 
        lblDanhSach.AutoSize = true;
        lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblDanhSach.Location = new System.Drawing.Point(20, 150);
        lblDanhSach.Name = "lblDanhSach";
        lblDanhSach.Size = new System.Drawing.Size(315, 21);
        lblDanhSach.TabIndex = 5;
        lblDanhSach.Text = "Lịch hẹn đã đặt trong phiên làm việc này:";
        // 
        // lstLichHen
        // 
        lstLichHen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        lstLichHen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lstLichHen.FormattingEnabled = true;
        lstLichHen.ItemHeight = 21;
        lstLichHen.Location = new System.Drawing.Point(20, 180);
        lstLichHen.Name = "lstLichHen";
        lstLichHen.Size = new System.Drawing.Size(420, 193);
        lstLichHen.TabIndex = 6;
        // 
        // frmLichHen
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(460, 395);
        Controls.Add(lstLichHen);
        Controls.Add(lblDanhSach);
        Controls.Add(btnDatLich);
        Controls.Add(dtpNgayHen);
        Controls.Add(lblNgayHen);
        Controls.Add(txtTenBenhNhan);
        Controls.Add(lblTenBenhNhan);
        MinimumSize = new System.Drawing.Size(400, 320);
        Name = "frmLichHen";
        StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        Text = "Đặt lịch hẹn";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
