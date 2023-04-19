using AppQLHS;
using BUS;
using DTO;
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
    public partial class frmQuanLyLop : Form
    {
        public frmQuanLyLop()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thoát", MessageBoxButtons.YesNoCancel);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            QuanLyLop_BUS ql = new QuanLyLop_BUS();
            if (string.IsNullOrEmpty(txtTenLop.Text) || string.IsNullOrEmpty(txtNamHoc.Text) || cbMaGiaoVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            }
            else
            {
                int idLop = (int)nudMaLop.Value;
                bool ktid = false;
                foreach (Lop_DTO a in ql.getLop())
                {
                    if (a.MaLop == idLop)
                    {
                        ktid = true;
                        break;
                    }
                }
                if (ktid)
                {
                    string tenLop = txtTenLop.Text;
                    string namHoc = txtNamHoc.Text;
                    string s = cbMaGiaoVien.SelectedItem.ToString() + " ";
                    string[] parts = s.Split('.');
                    int maGV = int.Parse(parts[0]);
                    Lop_DTO lop = new Lop_DTO(idLop, tenLop, maGV, namHoc);

                    bool kt = ql.updateLop(lop);
                    if (kt)
                    {
                        MessageBox.Show("Sửa lớp thành công!!!");
                        dgvQuanLyLop.DataSource = ql.getLop();
                        txtNamHoc.Text = "";
                        txtTenLop.Text = "";
                        nudMaLop.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Sửa lớp không thành công!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã lớp này không tồn tại vui lòng kiểm tra lại!!!");

                }
            }
        }

        private void frmQuanLyLop_Load(object sender, EventArgs e)
        {
            QuanLyLop_BUS ql = new QuanLyLop_BUS();
            GiaoVien_BUS gv = new GiaoVien_BUS();
            cbMaGiaoVien.DataSource = gv.loadGiaoVien();
            cbMaGiaoVien.DisplayMember = "Name";
            cbMaGiaoVien.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvQuanLyLop.DataSource = ql.getLop();

            rdMa.Checked = true;
            if (rdMa.Checked)
            {
                nudMaTK.Enabled = true;
                txtTenTK.Enabled = false;
            }
            else
            {
                nudMaTK.Enabled = true;
                txtTenTK.Enabled = false;
            }
            cbMaGiaoVien.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void rdMa_CheckedChanged(object sender, EventArgs e)
        {
            QuanLyLop_BUS ql = new QuanLyLop_BUS();
            dgvQuanLyLop.DataSource = ql.getLop();
            nudMaTK.Enabled = true;
            txtTenTK.Enabled = false;
        }

        private void rdTen_CheckedChanged(object sender, EventArgs e)
        {
            QuanLyLop_BUS ql = new QuanLyLop_BUS();
            dgvQuanLyLop.DataSource = ql.getLop();
            nudMaTK.Enabled = false;
            txtTenTK.Enabled = true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            QuanLyLop_BUS ql = new QuanLyLop_BUS();
            if (string.IsNullOrEmpty(txtTenLop.Text) || string.IsNullOrEmpty(txtNamHoc.Text) || cbMaGiaoVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            }
            else
            {
                int idLop = (int)nudMaLop.Value;
                bool ktid = true;
                foreach (Lop_DTO a in ql.getLop())
                {
                    if (a.MaLop == idLop)
                    {
                        ktid = false;
                    }
                }
                if (ktid)
                {
                    string tenLop = txtTenLop.Text;
                    string namHoc = txtNamHoc.Text;
                    string s = cbMaGiaoVien.SelectedItem.ToString() + " ";
                    string[] parts = s.Split('.');
                    int maGV = int.Parse(parts[0]);
                    Lop_DTO lop = new Lop_DTO(idLop, tenLop, maGV, namHoc);

                    bool kt = ql.addLop(lop);
                    if (kt)
                    {
                        MessageBox.Show("Thêm lớp mới thành công!!!");
                        dgvQuanLyLop.DataSource = ql.getLop();
                        txtNamHoc.Text = "";
                        txtTenLop.Text = "";
                        nudMaLop.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Thêm lớp mới không thành công!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã lớp này đã tồn tại vui lòng chọn mã lớp khác!!!");

                }
            }

        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (rdMa.Checked)
            {
                QuanLyLop_BUS ql = new QuanLyLop_BUS();
                int id = int.Parse(nudMaTK.Value.ToString());
                dgvQuanLyLop.DataSource = ql.getLopByID(id);
            }
            else
            {
                QuanLyLop_BUS ql = new QuanLyLop_BUS();
                string name = txtTenTK.Text;
                dgvQuanLyLop.DataSource = ql.getLopByName(name);
            }
        }

        private void dgvQuanLyLop_SelectionChanged(object sender, EventArgs e)
        {
            int vt = dgvQuanLyLop.CurrentCell.RowIndex;
            nudMaLop.Value = (int)dgvQuanLyLop.Rows[vt].Cells[0].Value;
            txtTenLop.Text = dgvQuanLyLop.Rows[vt].Cells[1].Value.ToString();
            int idgv = (int)dgvQuanLyLop.Rows[vt].Cells[2].Value;
            GiaoVien_BUS gvb = new GiaoVien_BUS();
            List<GiaoVien_DTO> listgv = gvb.loadGiaoVien();
            for (int i = 0; i < listgv.Count; i++)
            {
                if (listgv[i].MAGV1 == idgv)
                {
                    cbMaGiaoVien.SelectedIndex = i;
                    break;
                }
            }
            txtNamHoc.Text = dgvQuanLyLop.Rows[vt].Cells[3].Value.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa lớp có mã lớp là  " + nudMaLop.Value + " không?", "Thoát", MessageBoxButtons.YesNoCancel);
            if (rs == DialogResult.Yes)
            {
                QuanLyLop_BUS ql = new QuanLyLop_BUS();
                int idLop = (int)nudMaLop.Value;
                bool ktid = false;
                foreach (Lop_DTO a in ql.getLop())
                {
                    if (a.MaLop == idLop)
                    {
                        ktid = true;
                        break;
                    }
                }
                if (ktid)
                {
                    bool kt = ql.delLop(idLop);
                    if (kt)
                    {
                        MessageBox.Show("Xóa thành công!!!");
                        dgvQuanLyLop.DataSource = ql.getLop();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại không có mã lớp này!!!");
                }
            }
        }

        private void dgvQuanLyLop_DoubleClick(object sender, EventArgs e)
        {
            int vt = dgvQuanLyLop.CurrentCell.RowIndex;
            int id = (int)dgvQuanLyLop.Rows[vt].Cells[0].Value;
            string tenLop = dgvQuanLyLop.Rows[vt].Cells[1].Value.ToString();
            int idgv = (int)dgvQuanLyLop.Rows[vt].Cells[2].Value;
            string namHoc = dgvQuanLyLop.Rows[vt].Cells[3].Value.ToString();
            Lop_DTO lp = new Lop_DTO(id, tenLop, idgv,namHoc);
            frmChiTietLop ctl = new frmChiTietLop(lp);
            ctl.Show();
        }
    }
}
