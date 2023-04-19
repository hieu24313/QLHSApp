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
    public partial class frmDiem : Form
    {
        public HocSinh_DTO hss;
        public frmDiem(DTO.HocSinh_DTO hs)
        {
            InitializeComponent();
            txtTenHS.Text = hs.Ho + " " + hs.Ten;
            txtMaHocSinh.Text = hs.MaHS + " ";
            txtTenHS.Enabled = false;
            txtMaHocSinh.Enabled = false;
            hss = hs;

        }

        public void getNewIDDiem()
        {
            Diem_BUS d = new Diem_BUS();
            List<Diem_DTO> diem = d.getDiem();
            int temp = diem.Count - 1;
            nudMaDiem.Value = (int)diem[temp].MaDiem1 + 1;
        }
        private void frmDiem_Load(object sender, EventArgs e)
        {

            Mon_BUS m = new Mon_BUS();
            LoaiDiem_BUS lo = new LoaiDiem_BUS();
            cbLoaiDiem.DataSource = lo.getLoaiDiem();
            cbMon.DataSource = m.getMon();
            rdMa.Checked = true;

            string s = cbMon.SelectedItem.ToString() + "";
            string[] tempidMon = s.Split('.');
            int idMon = int.Parse((string)tempidMon[0]);

            Diem_BUS diem = new Diem_BUS();
            dgvDiem.DataSource = diem.getDiemByIDMon(hss.MaHS, idMon);
            cbMon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoaiDiem.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public void loadDiemDGV()
        {
            string s = cbMon.SelectedItem.ToString() + "";
            string[] tempidMon = s.Split('.');
            int idMon = int.Parse((string)tempidMon[0]);
            Diem_BUS diem = new Diem_BUS();
            dgvDiem.DataSource = diem.getDiemByIDMon(hss.MaHS, idMon);
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

        private void btThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiemSo.Text) || cbMon.SelectedIndex == -1 || cbLoaiDiem.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ đủ thông tin!!!");
            }
            else
            {
                Diem_BUS diem = new Diem_BUS();
                List<Diem_DTO> ktd = diem.getDiem();
                int idDiem = (int)nudMaDiem.Value;
                bool ktdiemtt = true;
                foreach (Diem_DTO diemdto in ktd)
                {
                    if (idDiem == diemdto.MaDiem1)
                    {
                        ktdiemtt = false;
                        break;
                    }
                }
                if (ktdiemtt)
                {
                    int idhs = int.Parse(txtMaHocSinh.Text);
                    float diemSo = float.Parse(txtDiemSo.Text);
                    string s = cbMon.SelectedItem.ToString() + "";
                    string[] tempidMon = s.Split('.');
                    int idMon = int.Parse((string)tempidMon[0]);
                    string s1 = cbLoaiDiem.SelectedItem.ToString() + "";
                    string[] tempidLD = s1.Split(".");
                    int idld = int.Parse((string)tempidLD[0]);
                    Diem_DTO d = new Diem_DTO(idDiem, diemSo, idhs, idMon, idld);
                    bool kt = diem.addDiem(d);
                    if (kt)
                    {
                        MessageBox.Show("Thêm điểm thành công!!!");
                        loadDiemDGV();
                        resetGiaTri();
                    }
                    else
                    {
                        MessageBox.Show("Thêm điểm thất bại!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã điểm đã tồn tại!!!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmChiTietDiem ctd = new frmChiTietDiem(hss);
            ctd.Show();
        }

        public void resetGiaTri()
        {
            txtDiemSo.Text = string.Empty;
            //getNewIDDiem();
        }

        private void dgvDiem_SelectionChanged(object sender, EventArgs e)
        {
            LoaiDiem_BUS ld = new LoaiDiem_BUS();
            Mon_BUS mon = new Mon_BUS();
            List<LoaiDiem_DTO> loaidiem = ld.getLoaiDiem();
            List<Mon_DTO> m = mon.getMon();
            int vt = dgvDiem.CurrentCell.RowIndex;
            txtDiemSo.Text = dgvDiem.Rows[vt].Cells[1].Value.ToString();
            int idMon = (int)dgvDiem.Rows[vt].Cells[3].Value;
            int idLoaiDiem = (int)dgvDiem.Rows[vt].Cells[4].Value;

            for (int i = 0; i < loaidiem.Count; i++)
            {
                if (idLoaiDiem == loaidiem[i].MaLoaiDiem)
                {
                    cbLoaiDiem.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < m.Count; i++)
            {
                if (idMon == m[i].MaMon)
                {
                    cbLoaiDiem.SelectedIndex = i;
                    break;
                }
            }


        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Diem_BUS diem = new Diem_BUS();
            List<Diem_DTO> ktd = diem.getDiem();
            int idDiem = (int)nudMaDiem.Value;
            bool ktdiemtt = false;
            foreach (Diem_DTO diemdto in ktd)
            {
                if (idDiem == diemdto.MaDiem1)
                {
                    ktdiemtt = true;
                    break;
                }
            }
            if (ktdiemtt)
            {
                int idhs = int.Parse(txtMaHocSinh.Text);
                float diemSo = float.Parse(txtDiemSo.Text);
                string s = cbMon.SelectedItem.ToString() + "";
                string[] tempidMon = s.Split('.');
                int idMon = int.Parse((string)tempidMon[0]);
                string s1 = cbLoaiDiem.SelectedItem.ToString() + "";
                string[] tempidLD = s1.Split(".");
                int idld = int.Parse((string)tempidLD[0]);
                Diem_DTO d = new Diem_DTO(idDiem, diemSo, idhs, idMon, idld);
                bool kt = diem.updateDiem(d);
                if (kt)
                {
                    MessageBox.Show("Cập nhật điểm thành công!!!");
                    loadDiemDGV();
                    resetGiaTri();
                }
                else
                {
                    MessageBox.Show("Cập nhật điểm thất bại!!!");
                }
            }
            else
            {
                MessageBox.Show("Không có mã loại điểm này!!!");
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Diem_BUS diem = new Diem_BUS();
            int iddiem = (int)nudMaDiem.Value;
            bool kt = diem.delDiem(iddiem);
            if (kt)
            {
                MessageBox.Show("Xóa điểm thành công!!!");
                loadDiemDGV();
                resetGiaTri();
            }
            else
            {
                MessageBox.Show("Xóa điểm không thành công!!!");
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            int id = (int)nudMaTK.Value;
            Diem_BUS d = new Diem_BUS();
            dgvDiem.DataSource = d.getDiemByID(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetGiaTri();
            Diem_BUS d = new Diem_BUS();
            loadDiemDGV();
        }
    }
}
