using BUS;
using DTO;
using QLHSApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLHSApp
{
    public partial class frmGiaoVien : Form
    {
        GiaoVien_BUS gv = new GiaoVien_BUS();

        public frmGiaoVien()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false; // chặn phóng to form
           // this.MinimizeBox = false; // chặn thu nhỏ form
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            rdMa.Checked = true;
            dgvGiaoVien.DataSource = gv.loadGiaoVien1();
            nudMaGV.Value = gv.loadGiaoVien().Last().MAGV1 + 1;
            txtHoGV.Text = "";
            txtTenGV.Text = "";
            txtQueQuanGV.Text = "";
            txtSODTGV.Text = "";
            nudMa.Value = 0;



            if (rdMa.Checked)
            {
                txtTimGV.Enabled = false;
            }
            if (rdTen.Checked)
            {
                nudMa.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Thoát", MessageBoxButtons.YesNoCancel);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }


        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            if (rdTen.Checked)
            {
                string t = this.txtTimGV.Text;
                List<GiaoVien_DTO> g = gv.loadGiaoVien(t);
                if (g.Count > 0)
                {
                    dgvGiaoVien.DataSource = g;
                }
                else
                {
                    MessageBox.Show("Không có giáo viên tên này!!!");
                }
            }
            else if (rdMa.Checked)
            {
                if ((int)nudMa.Value >= 0)
                {
                    int m = (int)nudMa.Value;
                    List<GiaoVien_DTO> id = gv.loadGiaoVienMa(m);
                    if (id.Count > 0)
                    {
                        dgvGiaoVien.DataSource = id;
                    }
                    else
                    {
                        MessageBox.Show("Không có giáo viên mang id này!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập id khác 0!!");
                }

            }
        }

        private void rdMa_CheckedChanged(object sender, EventArgs e)
        {
            GiaoVien_BUS gv = new GiaoVien_BUS();
            dgvGiaoVien.DataSource = gv.loadGiaoVien1();
            nudMa.Enabled = true;
            txtTimGV.Enabled = false;
        }

        private void rdTen_CheckedChanged(object sender, EventArgs e)
        {
            GiaoVien_BUS gv = new GiaoVien_BUS();
            dgvGiaoVien.DataSource = gv.loadGiaoVien1();
            nudMa.Enabled = false;
            txtTimGV.Enabled = true;
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenGV.Text) || string.IsNullOrEmpty(txtHoGV.Text) || string.IsNullOrEmpty(txtQueQuanGV.Text) || string.IsNullOrEmpty(txtSODTGV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            }
            else
            {
                GiaoVien_BUS gv1 = new GiaoVien_BUS();
                int ma = (int)nudMaGV.Value;
                bool ktg = true;
                List<GiaoVien_DTO> g = gv1.loadGiaoVien();
                foreach (GiaoVien_DTO v in g)
                {
                    if (v.MAGV1 == ma)
                    {
                        ktg = false;
                        break;
                    }
                }
                if (ktg)
                {
                    string ten = txtTenGV.Text;
                    string ho = txtHoGV.Text;
                    DateTime ns = dtpNgaySinhGV.Value;
                    string qq = txtQueQuanGV.Text;
                    string dt = txtSODTGV.Text;
                    GiaoVien_DTO gvadd = new GiaoVien_DTO(ma, ho, ten, ns, qq, dt);
                    bool kt = gv1.addGiaoVien(gvadd);
                    if (kt)
                    {
                        MessageBox.Show("Thêm Giáo Viên Thành Công!!!");
                        dgvGiaoVien.DataSource = gv.loadGiaoVien();
                        nudMaGV.Value = gv.loadGiaoVien().Last().MAGV1 + 1;
                        txtHoGV.Text = "";
                        txtTenGV.Text = "";
                        txtQueQuanGV.Text = "";
                        txtSODTGV.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Thêm Giáo Viên Thất bại!! Vui lòng kiểm tra lại mã giáo viên hoặc hệ thống đang có lỗi!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã giáo viên này đã tồn tại!!!");
                }

            }

        }

        private void dgvGiaoVien_SelectionChanged(object sender, EventArgs e)
        {
                int vt = dgvGiaoVien.CurrentCell.RowIndex;
                nudMaGV.Value = (int)dgvGiaoVien.Rows[vt].Cells[0].Value;
                txtHoGV.Text = dgvGiaoVien.Rows[vt].Cells[1].Value.ToString();
                txtTenGV.Text = dgvGiaoVien.Rows[vt].Cells[2].Value.ToString();
                dtpNgaySinhGV.Value = (DateTime)dgvGiaoVien.Rows[vt].Cells[3].Value;
                txtQueQuanGV.Text = dgvGiaoVien.Rows[vt].Cells[4].Value.ToString();
                txtSODTGV.Text = dgvGiaoVien.Rows[vt].Cells[5].Value.ToString();
            
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa giáo viên " + txtHoGV.Text + txtTenGV.Text + " không?",
                "Thoát", MessageBoxButtons.YesNoCancel);
            if (rs == DialogResult.Yes)
            {
                int id = (int)nudMaGV.Value;
                if (gv.delGiaoVien(id))
                {
                    dgvGiaoVien.DataSource = gv.loadGiaoVien();
                    nudMaGV.Value = gv.loadGiaoVien().Last().MAGV1 + 1;
                    txtHoGV.Text = "";
                    txtTenGV.Text = "";
                    txtQueQuanGV.Text = "";
                    txtSODTGV.Text = "";
                    MessageBox.Show("Xóa Thành Công!!");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!!");
                }
            }


        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            //lấy thông tin trên textbox => tạo giaovien dto và thêm vào gv2
            GiaoVien_BUS gv1 = new GiaoVien_BUS();
            int ma = (int)nudMaGV.Value;
            string ten = txtTenGV.Text;
            string ho = txtHoGV.Text;
            DateTime ns = dtpNgaySinhGV.Value;
            string qq = txtQueQuanGV.Text;
            string dt = txtSODTGV.Text;
            GiaoVien_DTO gvadd = new GiaoVien_DTO(ma, ho, ten, ns, qq, dt);
            bool kt = gv1.updateGiaoVien(gvadd);
            if (kt)
            {
                dgvGiaoVien.DataSource = gv.loadGiaoVien1();
                MessageBox.Show("Cập nhật thành công!!!");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!!!");
            }
            dgvGiaoVien.DataSource = gv.loadGiaoVien();
            nudMaGV.Value = gv.loadGiaoVien().Last().MAGV1 + 1;
            txtHoGV.Text = "";
            txtTenGV.Text = "";
            txtQueQuanGV.Text = "";
            txtSODTGV.Text = "";

        }
    }
}
