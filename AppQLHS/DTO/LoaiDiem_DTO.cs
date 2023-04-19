using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiDiem_DTO
    {
        private int maLoaiDiem;
        private string loai;
        private float heSo;
        private string moTa;

        public LoaiDiem_DTO() { }

        public override string ToString()
        {
            return $"{maLoaiDiem}. {loai}";
        }
        public LoaiDiem_DTO(int maLoaiDiem, string loai, float heSo, string moTa)
        {
            this.maLoaiDiem = maLoaiDiem;
            this.loai = loai;
            this.heSo = heSo;
            this.moTa = moTa;
        }

        public int MaLoaiDiem { get => maLoaiDiem; set => maLoaiDiem = value; }
        public string Loai { get => loai; set => loai = value; }
        public float HeSo { get => heSo; set => heSo = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
