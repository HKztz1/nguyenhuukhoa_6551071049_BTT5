namespace CafeStatusDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đổiMàuNềnToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblGioHienTai = new ToolStripStatusLabel();
            lblTenQuan = new ToolStripStatusLabel();
            lblTrangThai = new ToolStripStatusLabel();
            timeLock = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMàuNềnToolStripMenuItem, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(88, 24);
            hệThốngToolStripMenuItem.Text = "&Hệ Thống";
            // 
            // đổiMàuNềnToolStripMenuItem
            // 
            đổiMàuNềnToolStripMenuItem.Name = "đổiMàuNềnToolStripMenuItem";
            đổiMàuNềnToolStripMenuItem.Size = new Size(224, 26);
            đổiMàuNềnToolStripMenuItem.Text = "&Đổi Màu Nền";
            đổiMàuNềnToolStripMenuItem.Click += menuDoiMauNen_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(224, 26);
            thoátToolStripMenuItem.Text = "&Thoát";
            thoátToolStripMenuItem.Click += menuThoat_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblGioHienTai, lblTenQuan, lblTrangThai });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblGioHienTai
            // 
            lblGioHienTai.Name = "lblGioHienTai";
            lblGioHienTai.Size = new Size(151, 20);
            lblGioHienTai.Text = "toolStripStatusLabel1";
            lblGioHienTai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTenQuan
            // 
            lblTenQuan.Name = "lblTenQuan";
            lblTenQuan.Size = new Size(137, 20);
            lblTenQuan.Text = "CAFE ÁNH DƯƠNG";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(75, 20);
            lblTrangThai.Text = "Trạng thái";
            lblTrangThai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timeLock
            // 
            timeLock.Enabled = true;
            timeLock.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đổiMàuNềnToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblGioHienTai;
        private ToolStripStatusLabel lblTenQuan;
        private ToolStripStatusLabel lblTrangThai;
        private System.Windows.Forms.Timer timeLock;
    }
}
