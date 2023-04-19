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
    public partial class frmHocSinh : Form
    {
        public frmHocSinh()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát không?",
                 "Thoát", MessageBoxButtons.YesNoCancel);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa học sinh " + txtHo.Text + " " + txtTen.Text + " không?",
                "Thoát", MessageBoxButtons.YesNoCancel);
            if (rs == DialogResult.Yes)
            {
                int id = (int)nudMaHS.Value;
                HocSinh_BUS hs = new HocSinh_BUS();
                bool kt = hs.delHocSinh(id);
                if (kt)
                {
                    MessageBox.Show("Xóa thành công!!!");
                    resetGiaTri();
                    dgvHocSinh.DataSource = hs.getHocSinh();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!!!");
                }
            }
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            QuanLyLop_BUS lop = new QuanLyLop_BUS();
            cbMaL.DataSource = lop.getLop();
            rdMa.Checked = true;
            if (rdMa.Checked)
            {
                txtTenTK.Enabled = false;
            }
            else
            {
                nudMaHS.Enabled = false;
            }

            HocSinh_BUS hs = new HocSinh_BUS();
            dgvHocSinh.DataSource = hs.getHocSinh();
            cbMaL.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void resetGiaTri()
        {
            txtHo.Text = string.Empty;
            txtTen.Text = string.Empty;
            txtGioiTinh.Text = string.Empty;
            nudMaHS.Value = 0;
            cbMaL.SelectedIndex = 0;
        }

        private void rdMa_CheckedChanged(object sender, EventArgs e)
        {
            HocSinh_BUS hs = new HocSinh_BUS();
            dgvHocSinh.DataSource = hs.getHocSinh();
            txtTenTK.Enabled = false;
            nudMaTK.Enabled = true;
        }

        private void rdTen_CheckedChanged(object sender, EventArgs e)
        {
            HocSinh_BUS hs = new HocSinh_BUS();
            dgvHocSinh.DataSource = hs.getHocSinh();
            txtTenTK.Enabled = true;
            nudMaTK.Enabled = false;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            HocSinh_BUS hs = new HocSinh_BUS();
            if (rdMa.Checked)
            {
                int id = (int)nudMaTK.Value;
                dgvHocSinh.DataSource = hs.getHocSinhbyID(id);
            }
            else
            {
                string name = txtTenTK.Text;
                dgvHocSinh.DataSource = hs.getHocSinhbyTen(name);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHo.Text) || string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtGioiTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            }
            else
            {
                HocSinh_BUS h = new HocSinh_BUS();
                List<HocSinh_DTO> s1 = h.getHocSinh();
                int maHS = (int)nudMaHS.Value;
                bool ktid = true;
                foreach (HocSinh_DTO a in s1)
                {
                    if (a.MaHS == maHS)
                    {
                        ktid = false;
                        break;
                    }
                }
                if (ktid)
                {
                    string ho = txtHo.Text;
                    string ten = txtTen.Text;
                    DateTime ngaySinh = dtpNgaySinhHS.Value;
                    string gioitinh = txtGioiTinh.Text;
                    string s = cbMaL.SelectedItem.ToString() + " ";
                    string[] parts = s.Split('.');
                    int maLop = int.Parse(parts[0]);
                    HocSinh_DTO hs = new HocSinh_DTO(maHS, ho, ten, gioitinh, ngaySinh, maLop);

                    bool kt = h.addHocSinh(hs);
                    if (kt)
                    {
                        MessageBox.Show("Thêm học sinh thành công!!");
                        resetGiaTri();
                        dgvHocSinh.DataSource = h.getHocSinh();
                    }
                    else
                    {
                        MessageBox.Show("Thêm học sinh thất bại!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã học sinh này đã tồn tại !!!");
                }


            }
        }

        private void dgvHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            int vt = dgvHocSinh.CurrentCell.RowIndex;
            nudMaHS.Value = (int)dgvHocSinh.Rows[vt].Cells[0].Value;
            txtHo.Text = dgvHocSinh.Rows[vt].Cells[1].Value.ToString();
            txtTen.Text = dgvHocSinh.Rows[vt].Cells[2].Value.ToString();
            txtGioiTinh.Text = dgvHocSinh.Rows[vt].Cells[3].Value.ToString();
            dtpNgaySinhHS.Value = (DateTime)dgvHocSinh.Rows[vt].Cells[4].Value;
            int idlop = (int)dgvHocSinh.Rows[vt].Cells[5].Value;
            QuanLyLop_BUS ql = new QuanLyLop_BUS();
            List<Lop_DTO> lop = ql.getLop();
            for (int i = 0; i < lop.Count; i++)
            {
                if (lop[i].MaLop == idlop)
                {
                    cbMaL.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHo.Text) || string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtGioiTinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            }
            else
            {
                HocSinh_BUS h = new HocSinh_BUS();
                List<HocSinh_DTO> s1 = h.getHocSinh();
                int maHS = (int)nudMaHS.Value;
                bool ktid = false;
                foreach (HocSinh_DTO a in s1)
                {
                    if (a.MaHS == maHS)
                    {
                        ktid = true;
                        break;
                    }
                }
                if (ktid)
                {
                    string ho = txtHo.Text;
                    string ten = txtTen.Text;
                    DateTime ngaySinh = dtpNgaySinhHS.Value;
                    string gioitinh = txtGioiTinh.Text;
                    string s = cbMaL.SelectedItem.ToString() + " ";
                    string[] parts = s.Split('.');
                    int maLop = int.Parse(parts[0]);
                    HocSinh_DTO hs = new HocSinh_DTO(maHS, ho, ten, gioitinh, ngaySinh, maLop);

                    bool kt = h.updateHocSinh(hs);
                    if (kt)
                    {
                        MessageBox.Show("Cập nhật học sinh thành công!!");
                        resetGiaTri();
                        dgvHocSinh.DataSource = h.getHocSinh();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật học sinh thất bại!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã học sinh này không tồn tại !!!");
                }


            }
        }

        private void dgvHocSinh_DoubleClick(object sender, EventArgs e)
        {
            int vt = dgvHocSinh.CurrentCell.RowIndex;
            int maHS = (int)dgvHocSinh.Rows[vt].Cells[0].Value;
            string ho = dgvHocSinh.Rows[vt].Cells[1].Value.ToString();
            string ten = dgvHocSinh.Rows[vt].Cells[2].Value.ToString();
            string gioiTinh = dgvHocSinh.Rows[vt].Cells[3].Value.ToString();
            DateTime ngaySinh = (DateTime)dgvHocSinh.Rows[vt].Cells[4].Value;
            int maLop = (int)dgvHocSinh.Rows[vt].Cells[5].Value;
            HocSinh_DTO hs = new HocSinh_DTO(maHS, ho, ten, gioiTinh, ngaySinh, maLop);
            frmDiem ctd = new frmDiem(hs);
            ctd.Show();
        }
    }
}
