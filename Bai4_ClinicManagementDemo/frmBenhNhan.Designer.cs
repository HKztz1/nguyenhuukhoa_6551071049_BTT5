namespace Bai4_ClinicManagementDemo;

partial class frmBenhNhan
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label lblTuoi;
    private System.Windows.Forms.NumericUpDown numTuoi;
    private System.Windows.Forms.Label lblTrieuChung;
    private System.Windows.Forms.TextBox txtTrieuChung;
    private System.Windows.Forms.Button btnLuuTam;
    private System.Windows.Forms.Label lblDanhSach;
    private System.Windows.Forms.ListBox lstBenhNhan;

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
        lblHoTen = new System.Windows.Forms.Label();
        txtHoTen = new System.Windows.Forms.TextBox();
        lblTuoi = new System.Windows.Forms.Label();
        numTuoi = new System.Windows.Forms.NumericUpDown();
        lblTrieuChung = new System.Windows.Forms.Label();
        txtTrieuChung = new System.Windows.Forms.TextBox();
        btnLuuTam = new System.Windows.Forms.Button();
        lblDanhSach = new System.Windows.Forms.Label();
        lstBenhNhan = new System.Windows.Forms.ListBox();
        ((System.ComponentModel.ISupportInitialize)numTuoi).BeginInit();
        SuspendLayout();
        // 
        // lblHoTen
        // 
        lblHoTen.AutoSize = true;
        lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblHoTen.Location = new System.Drawing.Point(20, 20);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new System.Drawing.Size(60, 21);
        lblHoTen.TabIndex = 0;
        lblHoTen.Text = "Họ tên:";
        // 
        // txtHoTen
        // 
        txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        txtHoTen.Location = new System.Drawing.Point(120, 17);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new System.Drawing.Size(320, 29);
        txtHoTen.TabIndex = 1;
        // 
        // lblTuoi
        // 
        lblTuoi.AutoSize = true;
        lblTuoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblTuoi.Location = new System.Drawing.Point(20, 60);
        lblTuoi.Name = "lblTuoi";
        lblTuoi.Size = new System.Drawing.Size(43, 21);
        lblTuoi.TabIndex = 2;
        lblTuoi.Text = "Tuổi:";
        // 
        // numTuoi
        // 
        numTuoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        numTuoi.Location = new System.Drawing.Point(120, 58);
        numTuoi.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
        numTuoi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numTuoi.Name = "numTuoi";
        numTuoi.Size = new System.Drawing.Size(100, 29);
        numTuoi.TabIndex = 3;
        numTuoi.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // lblTrieuChung
        // 
        lblTrieuChung.AutoSize = true;
        lblTrieuChung.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblTrieuChung.Location = new System.Drawing.Point(20, 100);
        lblTrieuChung.Name = "lblTrieuChung";
        lblTrieuChung.Size = new System.Drawing.Size(95, 21);
        lblTrieuChung.TabIndex = 4;
        lblTrieuChung.Text = "Triệu chứng:";
        // 
        // txtTrieuChung
        // 
        txtTrieuChung.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        txtTrieuChung.Location = new System.Drawing.Point(120, 97);
        txtTrieuChung.Name = "txtTrieuChung";
        txtTrieuChung.Size = new System.Drawing.Size(320, 29);
        txtTrieuChung.TabIndex = 5;
        // 
        // btnLuuTam
        // 
        btnLuuTam.BackColor = System.Drawing.Color.MediumSeaGreen;
        btnLuuTam.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLuuTam.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        btnLuuTam.ForeColor = System.Drawing.Color.White;
        btnLuuTam.Location = new System.Drawing.Point(120, 137);
        btnLuuTam.Name = "btnLuuTam";
        btnLuuTam.Size = new System.Drawing.Size(120, 35);
        btnLuuTam.TabIndex = 6;
        btnLuuTam.Text = "Lưu tạm";
        btnLuuTam.UseVisualStyleBackColor = false;
        btnLuuTam.Click += btnLuuTam_Click;
        // 
        // lblDanhSach
        // 
        lblDanhSach.AutoSize = true;
        lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblDanhSach.Location = new System.Drawing.Point(20, 185);
        lblDanhSach.Name = "lblDanhSach";
        lblDanhSach.Size = new System.Drawing.Size(326, 21);
        lblDanhSach.TabIndex = 7;
        lblDanhSach.Text = "Bệnh nhân đã nhập trong phiên làm việc này:";
        // 
        // lstBenhNhan
        // 
        lstBenhNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        lstBenhNhan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lstBenhNhan.FormattingEnabled = true;
        lstBenhNhan.ItemHeight = 21;
        lstBenhNhan.Location = new System.Drawing.Point(20, 215);
        lstBenhNhan.Name = "lstBenhNhan";
        lstBenhNhan.Size = new System.Drawing.Size(435, 172);
        lstBenhNhan.TabIndex = 8;
        // 
        // frmBenhNhan
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(475, 410);
        Controls.Add(lstBenhNhan);
        Controls.Add(lblDanhSach);
        Controls.Add(btnLuuTam);
        Controls.Add(txtTrieuChung);
        Controls.Add(lblTrieuChung);
        Controls.Add(numTuoi);
        Controls.Add(lblTuoi);
        Controls.Add(txtHoTen);
        Controls.Add(lblHoTen);
        MinimumSize = new System.Drawing.Size(400, 350);
        Name = "frmBenhNhan";
        StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        Text = "Thông tin bệnh nhân";
        ((System.ComponentModel.ISupportInitialize)numTuoi).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
