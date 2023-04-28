using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HocSinh_BUS
    {

        public DataTable getHSByDTB()
        {
            HocSinh_DAL s = new HocSinh_DAL();
            return s.getHSByDTB();
        }
        public List<HocSinh_DTO> getHocSinh()
        {
            HocSinh_DAL hs = new HocSinh_DAL();
            return hs.getHocSinh();
        }

        public List<HocSinh_DTO> getHocSinhbyID(int id)
        {
            HocSinh_DAL hs = new HocSinh_DAL();
            return hs.getHocSinhByID(id);
        }

        public DataTable getHocSinhbyLopID(int id)
        {
            HocSinh_DAL hs = new HocSinh_DAL();
            return hs.getHocSinhbyLopID(id);
        }

        public List<HocSinh_DTO> getHocSinhbyTen(string ten)
        {
            HocSinh_DAL hs = new HocSinh_DAL();
            return hs.getHocSinhByTen(ten);
        }

        public bool addHocSinh(HocSinh_DTO hocSinh)
        {
            HocSinh_DAL hs = new HocSinh_DAL();
            bool kt = hs.addHocSinh(hocSinh);
            if (kt)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        public bool updateHocSinh(HocSinh_DTO hs)
        {
            HocSinh_DAL h = new HocSinh_DAL();
            bool kt = h.updateHocSinh(hs);
            if (kt)
            {
                return true;
            }
            else 
            {
                return false; 
            }
        }

        public bool delHocSinh(int id)
        {
            HocSinh_DAL h = new HocSinh_DAL();
            bool kt = h.delHocSinh(id);
            if (kt)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }
}
