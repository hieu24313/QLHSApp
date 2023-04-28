using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class LoaiDiem_BUS
    {
        LoaiDiem_DAL ld = new LoaiDiem_DAL();

        public DataTable getDiemDTT()
        {
            return ld.getDiemDTT();
        }
        public List<LoaiDiem_DTO> getLoaiDiem()
        {
            return ld.getLoaiDiem();
        }
        public List<LoaiDiem_DTO> getLoaiDiemid(int id)
        {
            return ld.getLoaiDiemid(id);
        }
        public List<LoaiDiem_DTO> getLoaiDiemten(string ten)
        {
            return ld.getLoaiDiemten(ten);
        }

        public bool addLoaiDiem(LoaiDiem_DTO d) 
        {
            bool kt = ld.addLoaiDiem(d);
            if (kt)
            {
                return true;
            }
            return false;
        }

        public bool delLoaiDiem(int id)
        {
            if (ld.delLoaiDiem(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateLoaiDiem(LoaiDiem_DTO loaidiem)
        {
            LoaiDiem_DAL ld = new LoaiDiem_DAL();
            bool kt = ld.updateLoaiDiem(loaidiem);
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
