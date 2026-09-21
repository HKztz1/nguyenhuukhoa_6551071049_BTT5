namespace Câu1
{
    partial class FormBanHang
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
            lblTieuDe = new Label();
            lblMaSP = new Label();
            txtMaSP = new TextBox();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            btnThem = new Button();
            btnXoaTrang = new Button();
            lblDanhSach = new Label();
            lstKetQua = new ListBox();
            lblGhiChu = new Label();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Navy;
            lblTieuDe.Location = new Point(12, 12);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(480, 32);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ NHẬP HÀNG SIÊU THỊ";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.Font = new Font("Segoe UI", 10F);
            lblMaSP.Location = new Point(32, 60);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(96, 19);
            lblMaSP.TabIndex = 1;
            lblMaSP.Text = "Mã sản phẩm:";
            // 
            // txtMaSP
            // 
            txtMaSP.Font = new Font("Segoe UI", 10F);
            txtMaSP.Location = new Point(145, 57);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(325, 25);
            txtMaSP.TabIndex = 2;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 10F);
            lblSoLuong.Location = new Point(32, 100);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(66, 19);
            lblSoLuong.TabIndex = 3;
            lblSoLuong.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 10F);
            txtSoLuong.Location = new Point(145, 97);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(325, 25);
            txtSoLuong.TabIndex = 4;
            txtSoLuong.KeyPress += txtChiNhapSo_KeyPress;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Segoe UI", 10F);
            lblDonGia.Location = new Point(32, 140);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(60, 19);
            lblDonGia.TabIndex = 5;
            lblDonGia.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 10F);
            txtDonGia.Location = new Point(145, 137);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(325, 25);
            txtDonGia.TabIndex = 6;
            txtDonGia.KeyPress += txtChiNhapSo_KeyPress;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightSteelBlue;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatStyle = FlatStyle.System;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.Location = new Point(145, 178);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 36);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm (F2)";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.BackColor = Color.WhiteSmoke;
            btnXoaTrang.Cursor = Cursors.Hand;
            btnXoaTrang.FlatStyle = FlatStyle.System;
            btnXoaTrang.Font = new Font("Segoe UI", 10F);
            btnXoaTrang.Location = new Point(320, 178);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(150, 36);
            btnXoaTrang.TabIndex = 8;
            btnXoaTrang.Text = "Xóa trắng (F5)";
            btnXoaTrang.UseVisualStyleBackColor = false;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lblDanhSach
            // 
            lblDanhSach.AutoSize = true;
            lblDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDanhSach.Location = new Point(32, 230);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(205, 19);
            lblDanhSach.TabIndex = 9;
            lblDanhSach.Text = "Danh sách sản phẩm đã nhập:";
            // 
            // lstKetQua
            // 
            lstKetQua.Font = new Font("Segoe UI", 10F);
            lstKetQua.FormattingEnabled = true;
            lstKetQua.ItemHeight = 17;
            lstKetQua.Location = new Point(32, 255);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(438, 174);
            lstKetQua.TabIndex = 10;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblGhiChu.ForeColor = Color.DimGray;
            lblGhiChu.Location = new Point(32, 439);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(270, 15);
            lblGhiChu.TabIndex = 11;
            lblGhiChu.Text = "Phím tắt: F2 = Thêm | F5 = Xóa trắng | Esc = Thoát";
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 468);
            Controls.Add(lblGhiChu);
            Controls.Add(lstKetQua);
            Controls.Add(lblDanhSach);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            Controls.Add(txtDonGia);
            Controls.Add(lblDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(lblSoLuong);
            Controls.Add(txtMaSP);
            Controls.Add(lblMaSP);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FormBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBanHang - Quản lý nhập liệu";
            KeyDown += FormBanHang_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblMaSP;
        private TextBox txtMaSP;
        private Label lblSoLuong;
        private TextBox txtSoLuong;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Button btnThem;
        private Button btnXoaTrang;
        private Label lblDanhSach;
        private ListBox lstKetQua;
        private Label lblGhiChu;
    }
}
