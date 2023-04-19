using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiDiem_DAL
    {

        public List<LoaiDiem_DTO> getLoaiDiem()
        {
            Connection conn = new Connection();
            List<LoaiDiem_DTO> ld = new List<LoaiDiem_DTO>();
            string sqlQuery = "SELECT * FROM LoaiDiem";
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LoaiDiem_DTO loaidiem = new LoaiDiem_DTO();
                            loaidiem.MaLoaiDiem = reader.GetInt32(0);
                            loaidiem.Loai = reader.GetString(1);
                            loaidiem.HeSo = float.Parse(reader.GetDouble(2).ToString());
                            loaidiem.MoTa = reader.GetString(3);
                            ld.Add(loaidiem);
                        }
                    }
                }
                conn.CloseConnection();
            }

            return ld;
        }

        public List<LoaiDiem_DTO> getLoaiDiemid(int id)
        {
            Connection conn = new Connection();
            List<LoaiDiem_DTO> ld = new List<LoaiDiem_DTO>();
            string sqlQuery = "SELECT * FROM LoaiDiem Where MaLoaiDiem like '%" + id + "%'";
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LoaiDiem_DTO loaidiem = new LoaiDiem_DTO();
                            loaidiem.MaLoaiDiem = reader.GetInt32(0);
                            loaidiem.Loai = reader.GetString(1);
                            loaidiem.HeSo = float.Parse(reader.GetDouble(2).ToString());
                            loaidiem.MoTa = reader.GetString(3);
                            ld.Add(loaidiem);
                        }
                    }
                }
                conn.CloseConnection();
            }

            return ld;
        }

        public List<LoaiDiem_DTO> getLoaiDiemten(string ten)
        {
            Connection conn = new Connection();
            List<LoaiDiem_DTO> ld = new List<LoaiDiem_DTO>();
            string sqlQuery = "SELECT * FROM LoaiDiem Where Ten Like '%" + ten  +"%'";
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LoaiDiem_DTO loaidiem = new LoaiDiem_DTO();
                            loaidiem.MaLoaiDiem = reader.GetInt32(0);
                            loaidiem.Loai = reader.GetString(1);
                            loaidiem.HeSo = float.Parse(reader.GetDouble(2).ToString());
                            loaidiem.MoTa = reader.GetString(3);
                            ld.Add(loaidiem);
                        }
                    }
                }
                conn.CloseConnection();
            }

            return ld;
        }


        public bool addLoaiDiem(LoaiDiem_DTO d)
        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "INSERT INTO LoaiDiem(MaLoaiDiem, Ten, HeSo, MoTa) " +
                "VALUES(N'" + d.MaLoaiDiem + "', N'" + d.Loai + "',N'" + d.HeSo + "', '" + d.MoTa +"')";

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

        public bool delLoaiDiem(int id)
        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "DELETE FROM LoaiDiem WHERE MaLoaiDiem = " + id + " ";
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

        public bool updateLoaiDiem(LoaiDiem_DTO loaidiem)
        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "UPDATE LoaiDiem set Ten = N'" + loaidiem.Loai + "', HeSo = N'" + loaidiem.HeSo + "', MoTa = N'" + loaidiem.MoTa +"' WHERE MaLoaiDiem="+loaidiem.MaLoaiDiem;
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

    }
}
