namespace Bai4_ClinicManagementDemo;

partial class frmParent
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuNghiepVu;
    private System.Windows.Forms.ToolStripMenuItem mnuThongTinBenhNhan;
    private System.Windows.Forms.ToolStripMenuItem mnuDatLichHen;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem mnuThoat;
    private System.Windows.Forms.ToolStripMenuItem mnuCuaSo;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;

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
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        mnuNghiepVu = new System.Windows.Forms.ToolStripMenuItem();
        mnuThongTinBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
        mnuDatLichHen = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
        mnuCuaSo = new System.Windows.Forms.ToolStripMenuItem();
        statusStrip1 = new System.Windows.Forms.StatusStrip();
        lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
        menuStrip1.SuspendLayout();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            mnuNghiepVu,
            mnuCuaSo
        });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.MdiWindowListItem = mnuCuaSo;
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(982, 28);
        menuStrip1.TabIndex = 1;
        menuStrip1.Text = "menuStrip1";
        // 
        // mnuNghiepVu
        // 
        mnuNghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            mnuThongTinBenhNhan,
            mnuDatLichHen,
            toolStripSeparator1,
            mnuThoat
        });
        mnuNghiepVu.Name = "mnuNghiepVu";
        mnuNghiepVu.Size = new System.Drawing.Size(91, 24);
        mnuNghiepVu.Text = "&Nghiệp vụ";
        // 
        // mnuThongTinBenhNhan
        // 
        mnuThongTinBenhNhan.Name = "mnuThongTinBenhNhan";
        mnuThongTinBenhNhan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
        mnuThongTinBenhNhan.Size = new System.Drawing.Size(277, 26);
        mnuThongTinBenhNhan.Text = "Thông tin &bệnh nhân";
        mnuThongTinBenhNhan.Click += mnuThongTinBenhNhan_Click;
        // 
        // mnuDatLichHen
        // 
        mnuDatLichHen.Name = "mnuDatLichHen";
        mnuDatLichHen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
        mnuDatLichHen.Size = new System.Drawing.Size(277, 26);
        mnuDatLichHen.Text = "Đặt &lịch hẹn";
        mnuDatLichHen.Click += mnuDatLichHen_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new System.Drawing.Size(274, 6);
        // 
        // mnuThoat
        // 
        mnuThoat.Name = "mnuThoat";
        mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
        mnuThoat.Size = new System.Drawing.Size(277, 26);
        mnuThoat.Text = "&Thoát";
        mnuThoat.Click += mnuThoat_Click;
        // 
        // mnuCuaSo
        // 
        mnuCuaSo.Name = "mnuCuaSo";
        mnuCuaSo.Size = new System.Drawing.Size(70, 24);
        mnuCuaSo.Text = "&Cửa sổ";
        // 
        // statusStrip1
        // 
        statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            lblTrangThai
        });
        statusStrip1.Location = new System.Drawing.Point(0, 627);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new System.Drawing.Size(982, 26);
        statusStrip1.TabIndex = 2;
        statusStrip1.Text = "statusStrip1";
        // 
        // lblTrangThai
        // 
        lblTrangThai.Name = "lblTrangThai";
        lblTrangThai.Size = new System.Drawing.Size(430, 20);
        lblTrangThai.Text = "Phần mềm Quản lý phòng khám mini (MDI + MdiWindowListItem)";
        // 
        // frmParent
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(982, 653);
        Controls.Add(statusStrip1);
        Controls.Add(menuStrip1);
        IsMdiContainer = true;
        MainMenuStrip = menuStrip1;
        MinimumSize = new System.Drawing.Size(800, 500);
        Name = "frmParent";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Bài 4: Quản lý phòng khám mini (MDI)";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
