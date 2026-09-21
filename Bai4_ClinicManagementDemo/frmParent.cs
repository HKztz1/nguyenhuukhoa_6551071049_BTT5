namespace Bai4_ClinicManagementDemo;

public partial class frmParent : Form
{
    private int _demBenhNhan = 0;
    private int _demLichHen = 0;

    public frmParent()
    {
        InitializeComponent();
    }

    private void mnuThongTinBenhNhan_Click(object sender, EventArgs e)
    {
        _demBenhNhan++;
        frmBenhNhan f = new frmBenhNhan();
        f.MdiParent = this;
        f.Text = $"Thông tin bệnh nhân #{_demBenhNhan}";
        f.Show();
    }

    private void mnuDatLichHen_Click(object sender, EventArgs e)
    {
        _demLichHen++;
        frmLichHen f = new frmLichHen();
        f.MdiParent = this;
        f.Text = $"Đặt lịch hẹn #{_demLichHen}";
        f.Show();
    }

    private void mnuThoat_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
