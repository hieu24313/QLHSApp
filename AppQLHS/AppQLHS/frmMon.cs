using BUS;
using DTO;
using System;
using System.Collections;
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
    public partial class frmMon : Form
    {
        public frmMon()
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

        private void btThemMon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenMon.Text) || nudMaMon.Value != 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");

            }
            else
            {
                int maMon = (int)nudMaMon.Value;
                Mon_BUS m = new Mon_BUS();
                List<Mon_DTO> listm = m.getMon();
                bool ktm = true;
                foreach (Mon_DTO monn in listm)
                {
                    if (monn.MaMon == maMon)
                    {
                        ktm = false;
                        break;
                    }
                }
                if (ktm)
                {
                    string tenMon = txtTenMon.Text;
                    Mon_DTO mon = new Mon_DTO(maMon, tenMon);
                    bool kt = m.addMon(mon);
                    if (kt)
                    {
                        MessageBox.Show("Thêm môn thành công!!");
                        dgvMon.DataSource = m.getMon();
                        resetGiaTri();
                    }
                    else
                    {
                        MessageBox.Show("Thêm môn không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Mã môn này đã tồn tại!!!");
                }

            }
        }

        private void frmMon_Load(object sender, EventArgs e)
        {
            Mon_BUS m = new Mon_BUS();
            dgvMon.DataSource = m.getMon();
            rdMa.Checked = true;
            if (rdMa.Checked)
            {
                txtTenMonTK.Enabled = false;
            }
            else
            {
                nudMaMonTK.Enabled = false;
            }
        }

        private void rdMa_CheckedChanged(object sender, EventArgs e)
        {
            Mon_BUS m = new Mon_BUS();
            dgvMon.DataSource = m.getMon();
            txtTenMonTK.Enabled = false;
            nudMaMonTK.Enabled = true;
        }

        private void rdTen_CheckedChanged(object sender, EventArgs e)
        {
            Mon_BUS m = new Mon_BUS();
            dgvMon.DataSource = m.getMon();
            nudMaMonTK.Enabled = false;
            txtTenMonTK.Enabled = true;
        }

        private void dgvMon_SelectionChanged(object sender, EventArgs e)
        {
            int vt = dgvMon.CurrentCell.ColumnIndex;
            nudMaMon.Value = (int)dgvMon.Rows[vt].Cells[0].Value;
            txtTenMon.Text = dgvMon.Rows[vt].Cells[1].Value.ToString();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            Mon_BUS mon = new Mon_BUS();
            if (rdMa.Checked)
            {
                int id = (int)nudMaMonTK.Value;
                dgvMon.DataSource = mon.getMonByID(id);
            }
            else
            {
                string ten = txtTenMonTK.Text;
                dgvMon.DataSource = mon.getMonByTen(ten);
            }
        }

        private void btSuaMon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenMon.Text) || nudMaMon.Value != 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            }
            else
            {
                Mon_BUS m = new Mon_BUS();
                int maMon = (int)nudMaMon.Value;
                List<Mon_DTO> listm = m.getMon();
                bool ktm = false;
                foreach (Mon_DTO monn in listm)
                {
                    if (monn.MaMon == maMon)
                    {
                        ktm = true;
                        break;
                    }
                }
                if (ktm)
                {
                    string tenMon = txtTenMon.Text;
                    Mon_DTO mon = new Mon_DTO(maMon, tenMon);
                    bool kt = m.updateMon(mon);
                    if (kt)
                    {
                        MessageBox.Show("Sửa môn thành công!!");
                        dgvMon.DataSource = m.getMon();
                        resetGiaTri();
                    }
                    else
                    {
                        MessageBox.Show("Sửa môn không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Không có mã môn này!!!");
                }

            }
        }

        private void btXoaMon_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa môn " + txtTenMon + " không?",
                "Thoát", MessageBoxButtons.YesNoCancel);
            if (rs == DialogResult.Yes)
            {
                Mon_BUS m = new Mon_BUS();
                int id = (int)nudMaMon.Value;
                bool kt = m.deleteMon(id);
                if (kt)
                {
                    MessageBox.Show("Xóa thành công!!!");
                    dgvMon.DataSource = m.getMon();
                    resetGiaTri();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!!!");
                }
            }

        }
        public void resetGiaTri()
        {
            txtTenMon.Text = string.Empty;
            nudMaMon.Value = 0;
        }
    }
}
