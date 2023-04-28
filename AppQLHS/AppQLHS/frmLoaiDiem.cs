using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLHSApp
{
    public partial class frmLoaiDiem : Form
    {
        public frmLoaiDiem()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false; // chặn phóng to form
           // this.MinimizeBox = false; // chặn thu nhỏ form
        }

        private void btnThoatLD_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Thoát", MessageBoxButtons.YesNoCancel);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void frmLoaiDiem_Load(object sender, EventArgs e)
        {
            LoaiDiem_BUS ld = new LoaiDiem_BUS();
            dgvLoaiDiem.DataSource = ld.getDiemDTT();
            rdMa.Checked = true;


            if (rdMa.Checked)
            {
                this.txtTenLoaiDiem.Enabled = false;
            }
            if (rdTen.Checked)
            {
                this.nudMaTK.Enabled = false;
            }
        }



        private void btnThemLD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtHeSo.Text) || string.IsNullOrEmpty(txtMoTa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            }
            else
            {
                LoaiDiem_BUS ld = new LoaiDiem_BUS();
                int maLoaiDiem = (int)nudMaLD.Value;
                List<LoaiDiem_DTO> ldbus = ld.getLoaiDiem();
                bool kttt = true;
                foreach (LoaiDiem_DTO l in ldbus)
                {
                    if (maLoaiDiem == l.MaLoaiDiem)
                    {
                        kttt = false;
                        break;
                    }
                }
                if (kttt)
                {
                    try
                    {


                        string ten = txtTen.Text;
                        float heSo = float.Parse(txtHeSo.Text);
                        String moTa = txtMoTa.Text;
                        LoaiDiem_DTO d = new LoaiDiem_DTO(maLoaiDiem, ten, heSo, moTa);
                        bool kt = ld.addLoaiDiem(d);
                        if (kt)
                        {
                            dgvLoaiDiem.DataSource = ld.getDiemDTT();
                            MessageBox.Show("Thêm Thành Công");
                            resetGiaTri();
                        }
                        else
                        {
                            MessageBox.Show("Thêm Thất Bại");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập số vào ô hệ số");
                    }
                }
                else
                {
                    MessageBox.Show("Mã loại điểm đã tồn tại vui lòng đổi mã khác!!!");
                }
            }

        }

        private void rdMa_CheckedChanged(object sender, EventArgs e)
        {
            LoaiDiem_BUS ld = new LoaiDiem_BUS();
            dgvLoaiDiem.DataSource = ld.getDiemDTT();
            nudMaTK.Enabled = true;
            txtTenLoaiDiem.Enabled = false;
        }

        private void rdTen_CheckedChanged(object sender, EventArgs e)
        {
            LoaiDiem_BUS ld = new LoaiDiem_BUS();
            dgvLoaiDiem.DataSource = ld.getDiemDTT();
            nudMaTK.Enabled = false;
            txtTenLoaiDiem.Enabled = true;
        }

        private void dgvLoaiDiem_SelectionChanged(object sender, EventArgs e)
        {
            int vt = dgvLoaiDiem.CurrentCell.RowIndex;
            nudMaLD.Value = (int)dgvLoaiDiem.Rows[vt].Cells[0].Value;
            txtTen.Text = dgvLoaiDiem.Rows[vt].Cells[1].Value.ToString();
            txtHeSo.Text = dgvLoaiDiem.Rows[vt].Cells[2].Value.ToString();
            txtMoTa.Text = dgvLoaiDiem.Rows[vt].Cells[3].Value.ToString();

        }

        private void btnXoaLD_Click(object sender, EventArgs e)
        {
            LoaiDiem_BUS ld = new LoaiDiem_BUS();
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa loại điểm " + txtTen.Text + " không?",
                "Thoát", MessageBoxButtons.YesNoCancel);
            if (rs == DialogResult.Yes)
            {
                bool kt = ld.delLoaiDiem((int)nudMaLD.Value);
                if (kt)
                {
                    MessageBox.Show("Xóa Thành Công!!!");
                    dgvLoaiDiem.DataSource = ld.getLoaiDiem();
                    this.resetGiaTri();
                }
                else
                {
                    MessageBox.Show("Xóa Thất Bại!!!");
                }

            }
        }

        private void resetGiaTri()
        {
            nudMaLD.Value = 0;
            txtTen.Text = "";
            txtHeSo.Text = "";
            txtMoTa.Text = "";
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            LoaiDiem_BUS ld = new LoaiDiem_BUS();
            if (rdMa.Checked == true)
            {
                int id = (int)nudMaTK.Value;
                List<LoaiDiem_DTO> loaiid = ld.getLoaiDiemid(id);
                if (loaiid == null)
                {
                    MessageBox.Show("Không có loại điểm mang id này!!");
                }
                else
                {

                    dgvLoaiDiem.DataSource = loaiid;
                }

            }
            else
            {
                List<LoaiDiem_DTO> loaid = ld.getLoaiDiemten(txtTenLoaiDiem.Text);
                if (loaid == null)
                {
                    MessageBox.Show("Không có loại điểm mang tên này!!");
                }
                else
                {
                    dgvLoaiDiem.DataSource = loaid;
                }
            }
        }

        private void btnSuaLD_Click(object sender, EventArgs e)
        {
            LoaiDiem_BUS ld = new LoaiDiem_BUS();
            int maLoaiDiem = (int)nudMaLD.Value;
            List<LoaiDiem_DTO> ldbus = ld.getLoaiDiem();
            bool kttt = false;
            foreach (LoaiDiem_DTO l in ldbus)
            {
                if (maLoaiDiem == l.MaLoaiDiem)
                {
                    kttt = true;
                    break;
                }
            }
            if (kttt)
            {
                string ten = txtTen.Text;
                string moTa = txtMoTa.Text;
                try
                {

                    float heSo = float.Parse(txtHeSo.Text);
                    bool kt = ld.updateLoaiDiem(new LoaiDiem_DTO(maLoaiDiem, ten, heSo, moTa));
                    if (kt)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        dgvLoaiDiem.DataSource = ld.getDiemDTT();
                        resetGiaTri();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra!!!");
                    }
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập số vào ô hệ số");
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại loại điểm mang mã bạn đã nhập!!!");
            }

        }
    }
}
