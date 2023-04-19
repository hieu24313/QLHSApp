using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop_DTO
    {
        private int maLop;
        private string tenLop;
        private int maGV;
        private string namHoc;

        public Lop_DTO() { }

        public override string ToString()
        {
            return $"{maLop}. {tenLop}";
        }

        public Lop_DTO(int maLop, string tenLop, int maGV, string namHoc)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.maGV = maGV;
            this.namHoc = namHoc;
        }

        public int MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public int MaGV { get => maGV; set => maGV = value; }
        public string NamHoc { get => namHoc; set => namHoc = value; }
    }
}
