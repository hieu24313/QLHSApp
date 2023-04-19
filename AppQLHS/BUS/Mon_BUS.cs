using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Mon_BUS
    {
        public List<Mon_DTO> getMon()
        {
            Mon_DAL mon = new Mon_DAL();
            return mon.getMon();
        }

        public List<Mon_DTO> getMonByID(int id)
        {
            Mon_DAL mon = new Mon_DAL();
            return mon.getDMonByid(id);
        }

        public List<Mon_DTO> getMonByTen(string ten)
        {
            Mon_DAL mon = new Mon_DAL();
            return mon.getDMonByTen(ten);
        }

        public bool addMon(Mon_DTO mon)
        {
            Mon_DAL m = new Mon_DAL();
            bool kt = m.addMon(mon);
            if (kt)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool updateMon(Mon_DTO mon)
        {
            Mon_DAL m = new Mon_DAL();
            bool kt = m.updateMon(mon);
            if (kt)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool deleteMon(int id)
        {
            Mon_DAL m = new Mon_DAL();
            bool kt = m.delMon(id);
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
