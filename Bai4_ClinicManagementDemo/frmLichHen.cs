namespace Bai4_ClinicManagementDemo;

public partial class frmLichHen : Form
{
    // Biến thành viên lưu trữ các lịch hẹn đã đặt trong phiên làm việc của cửa sổ này
    private List<string> danhSachLichHen = new List<string>();

    public frmLichHen()
    {
        InitializeComponent();
        dtpNgayHen.Value = DateTime.Now.AddHours(1);
    }

    private void btnDatLich_Click(object sender, EventArgs e)
    {
        string tenBenhNhan = txtTenBenhNhan.Text.Trim();
        if (string.IsNullOrWhiteSpace(tenBenhNhan))
        {
            MessageBox.Show("Vui lòng nhập tên bệnh nhân hẹn khám!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenBenhNhan.Focus();
            return;
        }

        string thongTinLichHen = $"{tenBenhNhan} - Hẹn lúc: {dtpNgayHen.Value:dd/MM/yyyy HH:mm}";

        // Lưu vào biến thành viên
        danhSachLichHen.Add(thongTinLichHen);

        // Hiển thị lên ListBox
        lstLichHen.Items.Add(thongTinLichHen);

        // Xóa ô nhập và dời giờ hẹn tiếp theo
        txtTenBenhNhan.Clear();
        dtpNgayHen.Value = dtpNgayHen.Value.AddMinutes(30);
        txtTenBenhNhan.Focus();
    }
}
