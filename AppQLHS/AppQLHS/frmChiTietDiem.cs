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

namespace AppQLHS
{
    public partial class frmChiTietDiem : Form
    {
        public HocSinh_DTO hocsinh;
        public frmChiTietDiem(DTO.HocSinh_DTO hs)
        {
            InitializeComponent();
            this.MaximizeBox = false; // chặn phóng to form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            hocsinh = hs;
        }

        private void frmChiTietDiem_Load(object sender, EventArgs e)
        {
            lbHoTen.Text = hocsinh.Ho + " " + hocsinh.Ten;
            QuanLyLop_BUS qll = new QuanLyLop_BUS();
            List<Lop_DTO> lop = qll.getLop();
            Mon_BUS m = new Mon_BUS();
            cbMon.DataSource = m.getMon();
            cbMon.SelectedIndex = 1;
            foreach (Lop_DTO l in lop)
            {
                if (hocsinh.MaLop == l.MaLop)
                {
                    lbLop.Text = l.TenLop;
                    break;
                }
            }
            string s = cbMon.SelectedItem.ToString() + "";
            string[] tempidMon = s.Split('.');
            int idMon = int.Parse((string)tempidMon[0]);
            int idhs = hocsinh.MaHS;
            Diem_BUS d = new Diem_BUS();
            dgvDiem.DataSource = d.getChiTietDiem(idhs, idMon);
            cbMon.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void cbMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = cbMon.SelectedItem.ToString() + "";
            string[] tempidMon = s.Split('.');
            int idMon = int.Parse((string)tempidMon[0]);
            int idhs = hocsinh.MaHS;
            Diem_BUS d = new Diem_BUS();
            dgvDiem.DataSource = d.getChiTietDiem(idhs, idMon);
        }
    }
}
