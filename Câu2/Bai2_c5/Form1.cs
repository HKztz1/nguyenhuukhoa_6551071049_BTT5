using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_c5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            toolTip1.AutoPopDelay = 5000; 
            toolTip1.InitialDelay = 500; 
            toolTip1.ReshowDelay = 100;  
            toolTip1.ShowAlways = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSDT_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblGoiTap_Click(object sender, EventArgs e)
        {

        }

        private void cboGoiTap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSoBuoiTap_Click(object sender, EventArgs e)
        {

        }

        private void numSoBuoiTuan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Số điện thoại",
                                "Thông báo cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning); 
                return;
            }
            string goiTap = cboGoiTap.SelectedItem != null ? cboGoiTap.SelectedItem.ToString() : "Chưa chọn";

            
            string thongTin = $"Họ tên: {txtHoTen.Text.Trim()}\n" +
                              $"SĐT: {txtSDT.Text.Trim()}\n" +
                              $"Gói tập: {goiTap}\n" +
                              $"Số buổi/tuần: {numSoBuoiTuan.Value}";

           
            MessageBox.Show(thongTin,
                            "Xác nhận thông tin đăng ký",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information); 
        }
    }
}
