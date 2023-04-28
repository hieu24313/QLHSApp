using DTO;
using GUI_QLHSApp;

namespace QLHSApp
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
            this.MaximizeBox = false; // chặn phóng to form
                                      // this.MinimizeBox = false; // chặn thu nhỏ form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void menuItemQLLOP_Click(object sender, EventArgs e)
        {
            frmQuanLyLop lp = new frmQuanLyLop();
            lp.Show();
        }

        private void menuItemDiem_Click(object sender, EventArgs e)
        {
            /*frmDiem d = new frmDiem();
            d.Show();*/
        }
        private void menuItemHS_Click(object sender, EventArgs e)
        {
            frmHocSinh hs = new frmHocSinh();
            hs.Show();
        }
        private void menuItemLD_Click(object sender, EventArgs e)
        {
            frmLoaiDiem ld = new frmLoaiDiem();
            ld.Show();
        }
        private void menuItemMon_Click(object sender, EventArgs e)
        {
            frmMon m = new frmMon();
            m.Show();
        }

        private void menuItemGV_Click(object sender, EventArgs e)
        {
            frmGiaoVien g = new frmGiaoVien();
            g.Show();

        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }
    }
}