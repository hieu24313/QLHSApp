using BUS;
using DTO;
using GUI_QLHSApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLHS
{
    public partial class frmChiTietLop : Form
    {
        public frmChiTietLop(DTO.Lop_DTO lp)
        {
            InitializeComponent();
            HocSinh_BUS hs = new HocSinh_BUS();
            dgvChiTietLop.DataSource = hs.getHocSinhbyLopID(lp.MaLop);
            lbTenLop.Text = lp.TenLop;
            lbNamHoc.Text = lp.NamHoc;
            GiaoVien_BUS gv = new GiaoVien_BUS();
            List<GiaoVien_DTO> giaoVien = gv.loadGiaoVien();
            foreach (GiaoVien_DTO g in giaoVien)
            {
                if (g.MAGV1 == lp.MaGV)
                {
                    lbGVCN.Text = g.HOGV1 + " " + g.TENGV1;
                    break;
                }
            }
            this.MaximizeBox = false; // chặn phóng to form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void frmChiTietLop_Load(object sender, EventArgs e)
        {


        }

        private void dgvChiTietLop_DoubleClick(object sender, EventArgs e)
        {
            int vt = dgvChiTietLop.CurrentCell.RowIndex;
            int maHS = (int)dgvChiTietLop.Rows[vt].Cells[0].Value;
            string ho = dgvChiTietLop.Rows[vt].Cells[1].Value.ToString();
            string ten = dgvChiTietLop.Rows[vt].Cells[2].Value.ToString();
            string gioiTinh = dgvChiTietLop.Rows[vt].Cells[3].Value.ToString();
            DateTime ngaySinh = (DateTime)dgvChiTietLop.Rows[vt].Cells[4].Value;
            int maLop = (int)dgvChiTietLop.Rows[vt].Cells[5].Value;
            HocSinh_DTO hs = new HocSinh_DTO(maHS, ho, ten, gioiTinh, ngaySinh, maLop);
            frmDiem ctd = new frmDiem(hs);
            ctd.Show();

        }
    }
}
