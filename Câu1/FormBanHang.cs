namespace Câu1
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Yêu cầu 2: Chỉ cho phép nhập chữ số (0–9) và phím Backspace dùng sự kiện KeyPress + e.Handled
        /// </summary>
        private void txtChiNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Yêu cầu 3: Thêm dòng vào ListBox định dạng "MaSP | SoLuong | DonGia"
        /// </summary>
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            string soLuong = txtSoLuong.Text.Trim();
            string donGia = txtDonGia.Text.Trim();

            if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(soLuong) || string.IsNullOrEmpty(donGia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã sản phẩm, Số lượng và Đơn giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dongKetQua = $"{maSP} | {soLuong} | {donGia}";
            lstKetQua.Items.Add(dongKetQua);
        }

        /// <summary>
        /// Yêu cầu 4: Xóa trắng toàn bộ 3 TextBox và focus về txtMaSP
        /// </summary>
        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtMaSP.Focus();
        }

        /// <summary>
        /// Yêu cầu 3, 4, 5, 6: Bắt các phím tắt F2, F5, Escape trên Form (KeyPreview = true)
        /// </summary>
        private void FormBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnThem.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnXoaTrang.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                e.Handled = true;
            }
        }
    }
}
