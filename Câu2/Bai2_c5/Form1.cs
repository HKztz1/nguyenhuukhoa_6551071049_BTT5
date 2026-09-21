using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bai2_c5
{
    public partial class Form1 : Form
    {
        // Biến lưu trạng thái đang giữ chuột trái để vẽ
        private bool isDrawing = false;

        // Biến lưu tọa độ điểm trước đó khi vẽ các đoạn thẳng liên tiếp
        private Point diemBatDau;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Yêu cầu 2 & 5: Khi nhấn chuột trái, bắt đầu vẽ và cập nhật trạng thái "Đang vẽ..."
        /// </summary>
        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                diemBatDau = e.Location;
                CapNhatThongTin(e.X, e.Y);
            }
        }

        /// <summary>
        /// Yêu cầu 2, 3, 5: Luôn cập nhật tọa độ chuột (X, Y); khi đang giữ chuột trái thì vẽ nét liên tục
        /// </summary>
        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            CapNhatThongTin(e.X, e.Y);

            // Khi đang giữ chuột trái và di chuyển chuột -> vẽ đường thẳng nối tiếp
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                using (Graphics g = pnlCanvas.CreateGraphics())
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    // Giúp nét vẽ mượt mà ở các khớp nối
                    pen.StartCap = LineCap.Round;
                    pen.EndCap = LineCap.Round;

                    g.DrawLine(pen, diemBatDau, e.Location);
                }

                // Cập nhật lại điểm bắt đầu cho đoạn vẽ tiếp theo
                diemBatDau = e.Location;
            }
        }

        /// <summary>
        /// Yêu cầu 2 & 5: Khi nhả chuột trái, kết thúc nét vẽ và chuyển trạng thái về "Sẵn sàng"
        /// </summary>
        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                CapNhatThongTin(e.X, e.Y);
            }
        }

        /// <summary>
        /// Yêu cầu 4: Nhấn chuột phải -> Xóa trắng Panel (Invalidate)
        /// </summary>
        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                isDrawing = false;
                pnlCanvas.Invalidate();
                CapNhatThongTin(e.X, e.Y);
            }
        }

        /// <summary>
        /// Cập nhật hiển thị tọa độ trên lblViTri và trạng thái trên Label
        /// </summary>
        private void CapNhatThongTin(int x, int y)
        {
            string trangThai = isDrawing ? "Đang vẽ..." : "Sẵn sàng";
            lblViTri.Text = $"Tọa độ: X = {x}, Y = {y} | {trangThai}";
            lblTrangThai.Text = $"Trạng thái: {trangThai}";
            lblTrangThai.ForeColor = isDrawing ? Color.Crimson : Color.ForestGreen;
        }
    }
}
