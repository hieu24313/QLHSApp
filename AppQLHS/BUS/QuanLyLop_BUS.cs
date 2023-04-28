using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BUS
{
    public class QuanLyLop_BUS
    {
        public DataTable getlopDTT()
        {
            QuanLyLop_DAL d = new QuanLyLop_DAL();
            return d.getlopDTT();
        }
        public List<Lop_DTO> getLop()
        {
            QuanLyLop_DAL qll = new QuanLyLop_DAL();
            return qll.getLop();
        }
        public List<Lop_DTO> getLopByID(int id)
        {
            QuanLyLop_DAL qll = new QuanLyLop_DAL();
            return qll.getLopByID(id);
        }

        public List<Lop_DTO> getLopByName(string name)
        {
            QuanLyLop_DAL qll = new QuanLyLop_DAL();
            return qll.getLopByName(name);
        }

        public bool addLop(Lop_DTO lop)
        {
            QuanLyLop_DAL ql = new QuanLyLop_DAL();
            bool kt = ql.addLop(lop);
            if (kt)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateLop(Lop_DTO lop)
        {
            QuanLyLop_DAL ql = new QuanLyLop_DAL();
            bool kt = ql.updateLop(lop);
            if (kt)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool delLop(int id)
        {
            QuanLyLop_DAL ql = new QuanLyLop_DAL();
            bool kt = ql.delLop(id);
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
