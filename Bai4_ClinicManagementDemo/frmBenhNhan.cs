namespace Bai4_ClinicManagementDemo;

public partial class frmBenhNhan : Form
{
    // Biến thành viên của form lưu trữ danh sách bệnh nhân phiên làm việc hiện tại
    private List<string> danhSachBenhNhan = new List<string>();

    public frmBenhNhan()
    {
        InitializeComponent();
    }

    private void btnLuuTam_Click(object sender, EventArgs e)
    {
        string hoTen = txtHoTen.Text.Trim();
        if (string.IsNullOrWhiteSpace(hoTen))
        {
            MessageBox.Show("Vui lòng nhập họ tên bệnh nhân!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtHoTen.Focus();
            return;
        }

        string trieuChung = string.IsNullOrWhiteSpace(txtTrieuChung.Text) ? "Không có" : txtTrieuChung.Text.Trim();
        string dongThongTin = $"{hoTen} - {numTuoi.Value} tuổi - Triệu chứng: {trieuChung}";

        // Lưu vào biến thành viên List<string>
        danhSachBenhNhan.Add(dongThongTin);

        // Hiển thị lên ListBox
        lstBenhNhan.Items.Add(dongThongTin);

        // Xóa ô nhập để nhập bệnh nhân tiếp theo
        txtHoTen.Clear();
        numTuoi.Value = 25;
        txtTrieuChung.Clear();
        txtHoTen.Focus();
    }
}
