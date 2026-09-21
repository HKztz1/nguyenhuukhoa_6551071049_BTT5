namespace Bai3_TodoListDemo;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label lblHeader;
    private System.Windows.Forms.Panel pnlInput;
    private System.Windows.Forms.Label lblNhap;
    private System.Windows.Forms.TextBox txtCongViecMoi;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.ListBox lstCongViec;
    private System.Windows.Forms.ContextMenuStrip cmsCongViec;
    private System.Windows.Forms.ToolStripMenuItem tsmiDanhDauHoanThanh;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem tsmiXoaCongViec;
    private System.Windows.Forms.ToolStripMenuItem tsmiXoaTatCa;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel lblHuongDan;

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
        pnlInput = new System.Windows.Forms.Panel();
        lblNhap = new System.Windows.Forms.Label();
        txtCongViecMoi = new System.Windows.Forms.TextBox();
        btnThem = new System.Windows.Forms.Button();
        lstCongViec = new System.Windows.Forms.ListBox();
        cmsCongViec = new System.Windows.Forms.ContextMenuStrip(components);
        tsmiDanhDauHoanThanh = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        tsmiXoaCongViec = new System.Windows.Forms.ToolStripMenuItem();
        tsmiXoaTatCa = new System.Windows.Forms.ToolStripMenuItem();
        statusStrip1 = new System.Windows.Forms.StatusStrip();
        lblHuongDan = new System.Windows.Forms.ToolStripStatusLabel();

        pnlInput.SuspendLayout();
        cmsCongViec.SuspendLayout();
        statusStrip1.SuspendLayout();
        SuspendLayout();

        // 
        // lblHeader
        // 
        lblHeader.BackColor = System.Drawing.Color.SteelBlue;
        lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
        lblHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblHeader.ForeColor = System.Drawing.Color.White;
        lblHeader.Location = new System.Drawing.Point(0, 0);
        lblHeader.Name = "lblHeader";
        lblHeader.Size = new System.Drawing.Size(650, 50);
        lblHeader.TabIndex = 0;
        lblHeader.Text = "DANH SÁCH CÔNG VIỆC CẦN LÀM (TO-DO LIST)";
        lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // 
        // pnlInput
        // 
        pnlInput.Controls.Add(lblNhap);
        pnlInput.Controls.Add(txtCongViecMoi);
        pnlInput.Controls.Add(btnThem);
        pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
        pnlInput.Location = new System.Drawing.Point(0, 50);
        pnlInput.Name = "pnlInput";
        pnlInput.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
        pnlInput.Size = new System.Drawing.Size(650, 60);
        pnlInput.TabIndex = 1;

        // 
        // lblNhap
        // 
        lblNhap.AutoSize = true;
        lblNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lblNhap.Location = new System.Drawing.Point(20, 19);
        lblNhap.Name = "lblNhap";
        lblNhap.Size = new System.Drawing.Size(125, 23);
        lblNhap.TabIndex = 0;
        lblNhap.Text = "Công việc mới:";

        // 
        // txtCongViecMoi
        // 
        txtCongViecMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        txtCongViecMoi.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        txtCongViecMoi.Location = new System.Drawing.Point(150, 15);
        txtCongViecMoi.Name = "txtCongViecMoi";
        txtCongViecMoi.PlaceholderText = "Nhập công việc cần làm rồi bấm Thêm hoặc nhấn Enter...";
        txtCongViecMoi.Size = new System.Drawing.Size(370, 31);
        txtCongViecMoi.TabIndex = 1;
        txtCongViecMoi.KeyDown += txtCongViecMoi_KeyDown;

        // 
        // btnThem
        // 
        btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        btnThem.BackColor = System.Drawing.Color.SteelBlue;
        btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
        btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        btnThem.ForeColor = System.Drawing.Color.White;
        btnThem.Location = new System.Drawing.Point(530, 13);
        btnThem.Name = "btnThem";
        btnThem.Size = new System.Drawing.Size(100, 35);
        btnThem.TabIndex = 2;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = false;
        btnThem.Click += btnThem_Click;

        // 
        // lstCongViec
        // 
        lstCongViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
        lstCongViec.ContextMenuStrip = cmsCongViec;
        lstCongViec.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        lstCongViec.FormattingEnabled = true;
        lstCongViec.ItemHeight = 25;
        lstCongViec.Location = new System.Drawing.Point(20, 120);
        lstCongViec.Name = "lstCongViec";
        lstCongViec.Size = new System.Drawing.Size(610, 329);
        lstCongViec.TabIndex = 2;
        lstCongViec.MouseDown += lstCongViec_MouseDown;

        // 
        // cmsCongViec
        // 
        cmsCongViec.ImageScalingSize = new System.Drawing.Size(20, 20);
        cmsCongViec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsmiDanhDauHoanThanh,
            toolStripSeparator1,
            tsmiXoaCongViec,
            tsmiXoaTatCa
        });
        cmsCongViec.Name = "cmsCongViec";
        cmsCongViec.Size = new System.Drawing.Size(223, 88);

        // 
        // tsmiDanhDauHoanThanh
        // 
        tsmiDanhDauHoanThanh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        tsmiDanhDauHoanThanh.ForeColor = System.Drawing.Color.DarkGreen;
        tsmiDanhDauHoanThanh.Name = "tsmiDanhDauHoanThanh";
        tsmiDanhDauHoanThanh.Size = new System.Drawing.Size(222, 26);
        tsmiDanhDauHoanThanh.Text = "✔ Đánh dấu hoàn thành";
        tsmiDanhDauHoanThanh.Click += tsmiDanhDauHoanThanh_Click;

        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new System.Drawing.Size(219, 6);

        // 
        // tsmiXoaCongViec
        // 
        tsmiXoaCongViec.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        tsmiXoaCongViec.ForeColor = System.Drawing.Color.DarkRed;
        tsmiXoaCongViec.Name = "tsmiXoaCongViec";
        tsmiXoaCongViec.Size = new System.Drawing.Size(222, 26);
        tsmiXoaCongViec.Text = "🗑 Xóa công việc này";
        tsmiXoaCongViec.Click += tsmiXoaCongViec_Click;

        // 
        // tsmiXoaTatCa
        // 
        tsmiXoaTatCa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        tsmiXoaTatCa.ForeColor = System.Drawing.Color.Crimson;
        tsmiXoaTatCa.Name = "tsmiXoaTatCa";
        tsmiXoaTatCa.Size = new System.Drawing.Size(222, 26);
        tsmiXoaTatCa.Text = "⚠ Xóa tất cả";
        tsmiXoaTatCa.Click += tsmiXoaTatCa_Click;

        // 
        // statusStrip1
        // 
        statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            lblHuongDan
        });
        statusStrip1.Location = new System.Drawing.Point(0, 467);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new System.Drawing.Size(650, 26);
        statusStrip1.TabIndex = 3;
        statusStrip1.Text = "statusStrip1";

        // 
        // lblHuongDan
        // 
        lblHuongDan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
        lblHuongDan.ForeColor = System.Drawing.Color.DimGray;
        lblHuongDan.Name = "lblHuongDan";
        lblHuongDan.Size = new System.Drawing.Size(437, 20);
        lblHuongDan.Text = "Nhấp chuột phải vào công việc để Đánh dấu hoàn thành hoặc Xóa.";

        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(650, 493);
        Controls.Add(statusStrip1);
        Controls.Add(lstCongViec);
        Controls.Add(pnlInput);
        Controls.Add(lblHeader);
        MinimumSize = new System.Drawing.Size(500, 400);
        Name = "Form1";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Bài 3: Danh sách việc cần làm hằng ngày (ContextMenuStrip)";
        pnlInput.ResumeLayout(false);
        pnlInput.PerformLayout();
        cmsCongViec.ResumeLayout(false);
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}

