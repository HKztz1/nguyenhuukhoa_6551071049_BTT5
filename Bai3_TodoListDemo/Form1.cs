namespace Bai3_TodoListDemo;

public partial class Form1 : Form
{
    private const string TienToHoanThanh = "[Hoàn thành] ";

    public Form1()
    {
        InitializeComponent();

        // Gán ContextMenuStrip cho lstCongViec theo yêu cầu đề bài
        lstCongViec.ContextMenuStrip = cmsCongViec;

        // Thêm một số công việc mẫu ban đầu
        lstCongViec.Items.Add("Ôn tập kiến thức Windows Forms");
        lstCongViec.Items.Add("Làm bài tập chương 4 C#");
        lstCongViec.Items.Add("Đọc tài liệu về MDI và MenuStrip");
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        string noiDung = txtCongViecMoi.Text.Trim();

        // Nếu txtCongViecMoi không rỗng thì Add nội dung vào lstCongViec.Items rồi Clear ô nhập
        if (!string.IsNullOrWhiteSpace(noiDung))
        {
            lstCongViec.Items.Add(noiDung);
            txtCongViecMoi.Clear();
            txtCongViecMoi.Focus();
        }
        else
        {
            MessageBox.Show("Vui lòng nhập nội dung công việc trước khi thêm!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCongViecMoi.Focus();
        }
    }

    private void txtCongViecMoi_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            btnThem_Click(sender, e);
            e.Handled = true;
            e.SuppressKeyPress = true; // Ngăn tiếng bip mặc định của Windows
        }
    }

    private void tsmiDanhDauHoanThanh_Click(object sender, EventArgs e)
    {
        // Nếu lstCongViec.SelectedItem khác null và chưa có tiền tố "[Hoàn thành] "
        if (lstCongViec.SelectedItem != null)
        {
            int selectedIndex = lstCongViec.SelectedIndex;
            string dongHienTai = lstCongViec.Items[selectedIndex].ToString() ?? string.Empty;

            if (!dongHienTai.StartsWith(TienToHoanThanh))
            {
                // Cập nhật lại item đó bằng cách chèn thêm tiền tố vào đầu chuỗi
                lstCongViec.Items[selectedIndex] = TienToHoanThanh + dongHienTai;
            }
            else
            {
                MessageBox.Show("Công việc này đã được đánh dấu hoàn thành từ trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else
        {
            MessageBox.Show("Vui lòng chọn một công việc để đánh dấu hoàn thành!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void tsmiXoaCongViec_Click(object sender, EventArgs e)
    {
        // Nếu có SelectedItem thì Remove khỏi danh sách
        if (lstCongViec.SelectedIndex != -1)
        {
            lstCongViec.Items.RemoveAt(lstCongViec.SelectedIndex);
        }
        else
        {
            // Nếu chưa chọn item nào thì hiển thị MessageBox nhắc chọn trước khi xóa
            MessageBox.Show("Vui lòng chọn công việc cần xóa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void tsmiXoaTatCa_Click(object sender, EventArgs e)
    {
        if (lstCongViec.Items.Count == 0)
        {
            MessageBox.Show("Danh sách công việc đang rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        // Hiển thị MessageBox dạng Yes/No hỏi xác nhận
        DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn xóa toàn bộ công việc trong danh sách?",
            "Xác nhận xóa tất cả",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        // Nếu Yes thì gọi lstCongViec.Items.Clear()
        if (result == DialogResult.Yes)
        {
            lstCongViec.Items.Clear();
        }
    }

    private void lstCongViec_MouseDown(object sender, MouseEventArgs e)
    {
        // Hỗ trợ nhấp chuột phải tự động chọn dòng dưới con trỏ chuột
        if (e.Button == MouseButtons.Right)
        {
            int index = lstCongViec.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                lstCongViec.SelectedIndex = index;
            }
        }
    }
}

