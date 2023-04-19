using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace DTO
{
    public class Diem_DTO
    {
        private int MaDiem;
        private float SoDiem;
        private int MaHS;
        private int MaMon;
        private int MaLoaiDiem;
        public Diem_DTO() { }

        

        public Diem_DTO(int maDiem, float soDiem, int maHS, int maMon, int maLoaiDiem)
        {
            MaDiem = maDiem;
            SoDiem = soDiem;
            MaHS = maHS;
            MaMon = maMon;
            MaLoaiDiem = maLoaiDiem;
        }

        public int MaDiem1 { get => MaDiem; set => MaDiem = value; }
        public float SoDiem1 { get => SoDiem; set => SoDiem = value; }
        public int MaHS1 { get => MaHS; set => MaHS = value; }
        public int MaMon1 { get => MaMon; set => MaMon = value; }
        public int MaLoaiDiem1 { get => MaLoaiDiem; set => MaLoaiDiem = value; }
    }
}
