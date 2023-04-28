using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class GiaoVien_BUS
    {
        GiaoVien_DAL gv = new GiaoVien_DAL();
        public List<GiaoVien_DTO> loadGiaoVien()
        {
            return gv.LoadGiaoVien();
        }

        public DataTable loadGiaoVien1()
        {
            GiaoVien_DAL g = new GiaoVien_DAL();
            return g.LoadGiaoVien1();
        }

        public List<GiaoVien_DTO> loadGiaoVien(string t)
        {
            return gv.LoadGiaoVienTen(t);
        }

        public List<GiaoVien_DTO> loadGiaoVienMa(int t)
        {
            return gv.LoadGiaoVienMa(t);
        }

        public bool addGiaoVien(GiaoVien_DTO g)
        {
            GiaoVien_DAL gv1 = new GiaoVien_DAL();
            if (gv1.addGiaoVien(g))
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
        public bool delGiaoVien(int id)
        {
            if (gv.delGiaoVien(id))
            {
                return true;
            }
            else { return false; }
        }

        public bool updateGiaoVien(GiaoVien_DTO gv)
        {
            GiaoVien_DAL gv1 = new GiaoVien_DAL();
            if (gv1.updateGiaoVien(gv))
            {
                return true;
            }
            else { return false; }
        }
    }
}