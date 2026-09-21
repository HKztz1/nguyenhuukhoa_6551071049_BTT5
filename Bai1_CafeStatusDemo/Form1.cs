namespace CafeStatusDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CapNhatThoiGianVaTrangThai();
        }
        private void timerClock_Tick(object sender, EventArgs e)
        {
            CapNhatThoiGianVaTrangThai();
        }
        private void CapNhatThoiGianVaTrangThai()
        {
            // 1. Cập nhật giờ hiện tại dạng HH:mm:ss
            lblGioHienTai.Text = DateTime.Now.ToString("HH:mm:ss");

            // 2. Kiểm tra giờ hiện tại (từ 0 đến 23)
            int currentHour = DateTime.Now.Hour;

            // Nếu giờ từ 6h sáng đến trước 22h tối (6 <= giờ < 22)
            if (currentHour >= 6 && currentHour < 22)
            {
                lblTrangThai.Text = "Đang mở cửa";
                lblTrangThai.ForeColor = Color.Green;
            }
            else
            {
                lblTrangThai.Text = "Đã đóng cửa";
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private void menuDoiMauNen_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                // Nếu người dùng chọn màu và bấm OK
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = colorDlg.Color; // Đổi màu nền của Form
                }
            }
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Đóng toàn bộ chương trình
        }
    }
}
