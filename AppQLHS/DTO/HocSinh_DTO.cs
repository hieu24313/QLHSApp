using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocSinh_DTO
    {
        private int maHS;
        private string ho;
        private string ten;
        private string gioiTinh;
        private DateTime ngaySinh;
        private int maLop;

        public HocSinh_DTO() { }

        public override string ToString()
        {
            return $"Mã Học Sinh: {maHS}, Tên học sinh: {ho + ten}";
        }
        public HocSinh_DTO(int maHS, string ho, string ten, string gioiTinh, DateTime ngaySinh, int maLop)
        {
            this.maHS = maHS;
            this.ho = ho;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.maLop = maLop;
        }

        public int MaHS { get => maHS; set => maHS = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public int MaLop { get => maLop; set => maLop = value; }

    }
}
