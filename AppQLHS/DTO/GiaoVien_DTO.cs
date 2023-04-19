using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoVien_DTO
    {
        private int MAGV;
        private string HOGV;
        private string TENGV;
        private DateTime NGAYSINH;
        private string QUEQUAN;
        private string SODT;

        public GiaoVien_DTO(int mAGV, string hOGV, string tENGV, DateTime nGAYSINH, string qUEQUAN, string sODT)
        {
            MAGV = mAGV;
            HOGV = hOGV;
            TENGV = tENGV;
            NGAYSINH = nGAYSINH;
            QUEQUAN = qUEQUAN;
            SODT = sODT;
        }

        public override string ToString()
        {
            return $"{MAGV}. {HOGV + " " + TENGV}";
        }

        public GiaoVien_DTO() { }

        public int MAGV1 { get => MAGV; set => MAGV = value; }
        public string HOGV1 { get => HOGV; set => HOGV = value; }
        public string TENGV1 { get => TENGV; set => TENGV = value; }
        public DateTime NGAYSINH1 { get => NGAYSINH; set => NGAYSINH = value; }
        public string QUEQUAN1 { get => QUEQUAN; set => QUEQUAN = value; }
        public string SODT1 { get => SODT; set => SODT = value; }
    }
        
}
