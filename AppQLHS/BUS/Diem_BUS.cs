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
    public class Diem_BUS
    {
        public List<Diem_DTO> getDiem()
        {
            Diem_DAL d = new Diem_DAL();
            return d.getDiem();
        }

        public List<Diem_DTO> getDiemByIDMon(int idhs, int idmon)
        {
            Diem_DAL d = new Diem_DAL();
            return d.getDiemByIDMon(idhs, idmon);
        }

        public List<Diem_DTO> getDiemByID(int id)
        {
            Diem_DAL d = new Diem_DAL();
            return d.getDiemByID(id);
        }

        public bool addDiem(Diem_DTO d)
        {
            Diem_DAL diem = new Diem_DAL();
            return diem.addDiem(d);
        }

        public bool updateDiem(Diem_DTO d)
        {
            Diem_DAL diem = new Diem_DAL();
            return diem.updateDiem(d);
        }

        public bool delDiem(int id)
        {
            Diem_DAL d = new Diem_DAL();
            return d.delDiem(id);
        }

        public DataTable getChiTietDiem(int idHS, int idMon )
        {
            Diem_DAL d = new Diem_DAL();
            DataTable dt = d.getChiTietDiem(idHS, idMon);
            return dt;
        }
    }
}
