using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuanLyLop_DAL
    {
        public DataTable getlopDTT()
        {

            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "SELECT Lop.MaLop as \"Mã Lớp\", Lop.TenLop as \"Tên Lớp\", Lop.MaGV as \"Giáo Viên Chủ Nhiệm\", Lop.NamHoc as \"Năm Học\" \r\nFrom Lop";
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

        public List<Lop_DTO> getLop()
        {
            Connection conn = new Connection();
            List<Lop_DTO> lop = new List<Lop_DTO>();
            string sqlQuery = "SELECT * FROM Lop";
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Lop_DTO lopHoc = new Lop_DTO();
                            lopHoc.MaLop = reader.GetInt32(0);
                            lopHoc.TenLop = reader.GetString(1);
                            lopHoc.MaGV = reader.GetInt32(2);
                            lopHoc.NamHoc = reader.GetString(3);
                            lop.Add(lopHoc);
                        }
                    }
                }
                conn.CloseConnection();
            }

            return lop;
        }

        public List<Lop_DTO> getLopByID(int id)
        {
            Connection conn = new Connection();
            List<Lop_DTO> lop = new List<Lop_DTO>();
            string sqlQuery = "SELECT * FROM Lop WHERE MaLop LIKE '%" + id + "%'";
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Lop_DTO lopHoc = new Lop_DTO();
                            lopHoc.MaLop = reader.GetInt32(0);
                            lopHoc.TenLop = reader.GetString(1);
                            lopHoc.MaGV = reader.GetInt32(2);
                            lopHoc.NamHoc = reader.GetString(3);
                            lop.Add(lopHoc);
                        }
                    }
                }
                conn.CloseConnection();
            }

            return lop;
        }

        public List<Lop_DTO> getLopByName(string name)
        {
            Connection conn = new Connection();
            List<Lop_DTO> lop = new List<Lop_DTO>();
            string sqlQuery = "SELECT * FROM Lop WHERE TenLop LIKE '%" + name + "%'";
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Lop_DTO lopHoc = new Lop_DTO();
                            lopHoc.MaLop = reader.GetInt32(0);
                            lopHoc.TenLop = reader.GetString(1);
                            lopHoc.MaGV = reader.GetInt32(2);
                            lopHoc.NamHoc = reader.GetString(3);
                            lop.Add(lopHoc);
                        }
                    }
                }
                conn.CloseConnection();
            }

            return lop;
        }

        public bool addLop(Lop_DTO lop)
        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "INSERT INTO Lop(MaLop, TenLop, MaGV, NamHoc) " +
                "VALUES(N'" + lop.MaLop + "', N'" + lop.TenLop + "',N'" + lop.MaGV + "', '" + lop.NamHoc + "')";

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

        public bool updateLop(Lop_DTO lop)
        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "UPDATE Lop set TenLop = N'" + lop.TenLop + "', MaGV = N'" + lop.MaGV + "', NamHoc = N'" + lop.NamHoc + "' WHERE MaLop = '" + lop.MaLop + "'";
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
        public bool delLop(int id)
        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "DELETE FROM Lop WHERE MaLop = " + id + " ";
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
    }
}
