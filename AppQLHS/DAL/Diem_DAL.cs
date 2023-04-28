using DTO;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Diem_DAL
    {
        public List<Diem_DTO> getDiem()
        {
            Connection conn = new Connection();
            List<Diem_DTO> d = new List<Diem_DTO>();
            string sqlQuery = "SELECT * FROM Diem";
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Diem_DTO diem = new Diem_DTO();
                            diem.MaDiem1 = reader.GetInt32(0);
                            diem.SoDiem1 = float.Parse(reader.GetDouble(1).ToString());
                            diem.MaHS1 = reader.GetInt32(2);
                            diem.MaMon1 = reader.GetInt32(3);
                            diem.MaLoaiDiem1 = reader.GetInt32(4);
                            d.Add(diem);
                        }
                    }
                }
            }
            return d;
        }

        public List<Diem_DTO> getDiemByIDMon(int idhs, int idMon)
        {
            Connection conn = new Connection();
            List<Diem_DTO> d = new List<Diem_DTO>();
            string sqlQuery = "SELECT * FROM Diem where MaHS=" + idhs + "AND MaMon =" + idMon;
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Diem_DTO diem = new Diem_DTO();
                            diem.MaDiem1 = reader.GetInt32(0);
                            diem.SoDiem1 = float.Parse(reader.GetDouble(1).ToString());
                            diem.MaHS1 = reader.GetInt32(2);
                            diem.MaMon1 = reader.GetInt32(3);
                            diem.MaLoaiDiem1 = reader.GetInt32(4);
                            d.Add(diem);
                        }
                    }
                }
            }
            return d;
        }

        public List<Diem_DTO> getDiemByID(int id)
        {
            Connection conn = new Connection();
            List<Diem_DTO> d = new List<Diem_DTO>();
            string sqlQuery = "SELECT * FROM Diem where MaDiem="+id;
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Diem_DTO diem = new Diem_DTO();
                            diem.MaDiem1 = reader.GetInt32(0);
                            diem.SoDiem1 = float.Parse(reader.GetDouble(1).ToString());
                            diem.MaHS1 = reader.GetInt32(2);
                            diem.MaMon1 = reader.GetInt32(3);
                            diem.MaLoaiDiem1 = reader.GetInt32(4);
                            d.Add(diem);
                        }
                    }
                }
            }
            return d;
        }


        public bool addDiem(Diem_DTO diema)
        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "INSERT INTO Diem(MaDiem, DiemSo, MaHS, MaMon, MaLoaiDiem) " +
            "VALUES(N'" + diema.MaDiem1 + "', N'" + diema.SoDiem1 + "',N'" + diema.MaHS1 + "', '" + diema.MaMon1 + "', N'" + diema.MaLoaiDiem1 + "')";

            SqlCommand command = new SqlCommand(sqlQuery, connection);
            try
            {
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                connection.Close();
                return false;
            }
        }


        public bool updateDiem(Diem_DTO diem)
        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "UPDATE Diem set DiemSo = N'" + diem.SoDiem1 + "', MaHS = N'" + diem.MaHS1 + "', MaMon = N'" + diem.MaMon1 + "', MaLoaiDiem = N'"+ diem.MaLoaiDiem1 +"' WHERE MaDiem = '" + diem.MaDiem1 + "'";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            try
            {
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool delDiem(int id)
        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "DELETE FROM Diem WHERE MaDiem = " + id + " ";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            try
            {
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                connection.Close();
                return false;
            }
        }

        public DataTable getChiTietDiem(int MaHS, int MaMon)
        {

            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "SELECT Diem.MaDiem as \"Mã Điểm\", Diem.DiemSo as \"Điểm Số\", LoaiDiem.Ten as \"Loại Điểm\" \r\nFROM Diem\r\nJOIN HocSinh ON Diem.MaHS = HocSinh.MaHS\r\nJOIN Mon ON Diem.MaMon = Mon.MaMon\r\nJOIN LoaiDiem ON Diem.MaLoaiDiem = LoaiDiem.MaLoaiDiem\r\nWhere HocSinh.MaHS = " + MaHS + " AND Mon.MaMon =" + MaMon + ";";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            try
            {
                da.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception)
            {
                connection.Close();
                return dt;
            }
        }
    }
}
