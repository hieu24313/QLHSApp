using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace DTO
{
    public class Mon_DTO
    {
        private int maMon;
        private string tenMon;
        public Mon_DTO() { }

        public override string ToString()
        {
            return $"{maMon}. {tenMon}";
        }
        public Mon_DTO(int maMon, string tenMon)
        {
            this.maMon = maMon;
            this.tenMon = tenMon;
        }

        public int MaMon { get => maMon; set => maMon = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
    }
}
