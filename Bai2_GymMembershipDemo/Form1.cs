namespace Bai2_GymMembershipDemo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        // Thiết lập các thuộc tính của ToolTip1 trong code (ở constructor Form)
        toolTip1.AutoPopDelay = 5000;
        toolTip1.InitialDelay = 500;
        toolTip1.ReshowDelay = 100;
        toolTip1.ShowAlways = true;

        // Cấu hình nội dung ToolTip cho từng control
        toolTip1.SetToolTip(txtHoTen, "Nhập đầy đủ họ và tên của hội viên");
        toolTip1.SetToolTip(txtSDT, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
        toolTip1.SetToolTip(txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
        toolTip1.SetToolTip(dtpNgaySinh, "Chọn ngày tháng năm sinh của hội viên");
        toolTip1.SetToolTip(cboGoiTap, "Gói VIP và Premium có kèm huấn luyện viên riêng");
        toolTip1.SetToolTip(numSoBuoiTuan, "Chọn số buổi tập trong tuần (từ 1 đến 7 buổi)");
        toolTip1.SetToolTip(btnDangKy, "Nhấn để xác nhận đăng ký hội viên");
        toolTip1.SetToolTip(btnNhapLai, "Nhấn để xóa dữ liệu đang nhập và làm mới form");
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        if (cboGoiTap.Items.Count > 0)
        {
            cboGoiTap.SelectedIndex = 0; // Mặc định gói Basic
        }
    }

    private void btnDangKy_Click(object sender, EventArgs e)
    {
        // Kiểm tra xem Họ tên hoặc Số điện thoại có bị để trống hay không
        if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
        {
            MessageBox.Show(
                "Vui lòng nhập đầy đủ Họ tên và Số điện thoại",
                "Cảnh báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
                txtHoTen.Focus();
            else
                txtSDT.Focus();

            return;
        }

        // Tổng hợp thông tin vừa nhập
        string thongTin = $"--- THÔNG TIN ĐĂNG KÝ HỘI VIÊN ---\n\n" +
                          $"• Họ tên: {txtHoTen.Text.Trim()}\n" +
                          $"• Số điện thoại: {txtSDT.Text.Trim()}\n" +
                          $"• Email: {(string.IsNullOrWhiteSpace(txtEmail.Text) ? "Chưa cung cấp" : txtEmail.Text.Trim())}\n" +
                          $"• Ngày sinh: {dtpNgaySinh.Value:dd/MM/yyyy}\n" +
                          $"• Gói tập: {cboGoiTap.SelectedItem}\n" +
                          $"• Số buổi/tuần: {numSoBuoiTuan.Value} buổi";

        MessageBox.Show(thongTin, "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnNhapLai_Click(object sender, EventArgs e)
    {
        txtHoTen.Clear();
        txtSDT.Clear();
        txtEmail.Clear();
        dtpNgaySinh.Value = new DateTime(2000, 1, 1);
        if (cboGoiTap.Items.Count > 0)
            cboGoiTap.SelectedIndex = 0;
        numSoBuoiTuan.Value = 3;
        txtHoTen.Focus();
    }
}

