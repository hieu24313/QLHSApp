using DTO;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Data;

namespace DAL
{
    
    public class HocSinh_DAL
    {
        public DataTable getHSByDTB()
        {

            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "SELECT HocSinh.MaHS as \"Mã Học Sinh\", HocSinh.Ho as \"Họ\", HocSinh.Ten as \"Tên\", HocSinh.GioiTinh as \"Giới Tính\", HocSinh.NgaySinh as \"Ngày Sinh\", HocSinh.MaLop as \"Mã Lớp\" FROM HocSinh";
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
        public List<HocSinh_DTO> getHocSinh()
        {
            Connection conn = new Connection();
            List<HocSinh_DTO> hs = new List<HocSinh_DTO>();
            string sqlQuery = "SELECT HocSinh.MaHS as \"Mã Học Sinh\", HocSinh.Ho as \"Họ\", HocSinh.Ten as \"Tên\", HocSinh.GioiTinh as \"Giới Tính\", HocSinh.NgaySinh as \"Ngày Sinh\", HocSinh.MaLop as \"Mã Lớp\" FROM HocSinh";
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HocSinh_DTO h = new HocSinh_DTO();
                            h.MaHS = reader.GetInt32(0);
                            h.Ho = reader.GetString(1);
                            h.Ten = reader.GetString(2);
                            h.GioiTinh = reader.GetString(3);
                            h.NgaySinh = reader.GetDateTime(4);
                            h.MaLop = reader.GetInt32(5);
                            hs.Add(h);
                        }
                    }
                }
            } return hs;
        }

        public DataTable getHocSinhbyLopID(int MaLop)
        {

            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "SELECT HocSinh.MaHS as \"Mã Học Sinh\", HocSinh.Ho as \"Họ\", HocSinh.Ten as \"Tên\", HocSinh.GioiTinh as \"Giới Tính\", HocSinh.NgaySinh as \"Ngày Sinh\" FROM HocSinh where MaLop =" + MaLop + ";";
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

        /*public List<HocSinh_DTO> getHocSinhbyLopID(int id)
        {
            Connection conn = new Connection();
            List<HocSinh_DTO> hs = new List<HocSinh_DTO>();
            string sqlQuery = "SELECT * FROM HocSinh WHERE MaLop=" + id;
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HocSinh_DTO h = new HocSinh_DTO();
                            h.MaHS = reader.GetInt32(0);
                            h.Ho = reader.GetString(1);
                            h.Ten = reader.GetString(2);
                            h.GioiTinh = reader.GetString(3);
                            h.NgaySinh = reader.GetDateTime(4);
                            h.MaLop = reader.GetInt32(5);
                            hs.Add(h);
                        }
                    }
                }
            }
            return hs;
        }*/

        public List<HocSinh_DTO> getHocSinhByID(int id)
        {
            Connection conn = new Connection();
            List<HocSinh_DTO> hs = new List<HocSinh_DTO>();
            string sqlQuery = "SELECT * FROM HocSinh Where MaHS LIKE '%"+id+"%'";
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HocSinh_DTO h = new HocSinh_DTO();
                            h.MaHS = reader.GetInt32(0);
                            h.Ho = reader.GetString(1);
                            h.Ten = reader.GetString(2);
                            h.GioiTinh = reader.GetString(3);
                            h.NgaySinh = reader.GetDateTime(4);
                            h.MaLop = reader.GetInt32(5);
                            hs.Add(h);
                        }
                    }
                }
                conn.CloseConnection();
            }
            return hs;
        }

        public List<HocSinh_DTO> getHocSinhByTen(string ten)
        {
            Connection conn = new Connection();
            List<HocSinh_DTO> hs = new List<HocSinh_DTO>();
            string sqlQuery = "SELECT * FROM HocSinh Where Ten LIKE '%" + ten + "%'";
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HocSinh_DTO h = new HocSinh_DTO();
                            h.MaHS = reader.GetInt32(0);
                            h.Ho = reader.GetString(1);
                            h.Ten = reader.GetString(2);
                            h.GioiTinh = reader.GetString(3);
                            h.NgaySinh = reader.GetDateTime(4);
                            h.MaLop = reader.GetInt32(5);
                            hs.Add(h);
                        }
                    }
                }
                conn.CloseConnection();
            }
            return hs;
        }

        public bool addHocSinh(HocSinh_DTO h)
        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "INSERT INTO HocSinh(MaHS, Ho, Ten, GioiTinh, NgaySinh, MaLop) " +
                "VALUES(N'" + h.MaHS + "', N'" + h.Ho + "',N'" + h.Ten + "', '" + h.GioiTinh + "',N'" + h.NgaySinh + "', '" + h.MaLop + "')";

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

        public bool delHocSinh(int id)
        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "DELETE FROM HocSinh WHERE MaHS = " + id + " ";
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

        public bool updateHocSinh(HocSinh_DTO hs)
        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "UPDATE HocSinh set Ho = N'" + hs.Ho + "', Ten = N'" + hs.Ten + "', NgaySinh = N'" + hs.NgaySinh + "', GioiTinh = N'" + hs.GioiTinh + "',MaLop = N'" + hs.MaLop + "' WHERE MaHS = '" + hs.MaHS + "'";
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
