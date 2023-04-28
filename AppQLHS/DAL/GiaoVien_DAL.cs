using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class GiaoVien_DAL
    {
        public List<GiaoVien_DTO> LoadGiaoVien()
        {
            Connection conn = new Connection();
            List<GiaoVien_DTO> gv = new List<GiaoVien_DTO>();
            string sqlQuery = "SELECT * FROM GiaoVien";
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GiaoVien_DTO giaoVien = new GiaoVien_DTO();
                            giaoVien.MAGV1 = reader.GetInt32(0);
                            giaoVien.HOGV1 = reader.GetString(1);
                            giaoVien.TENGV1 = reader.GetString(2);
                            giaoVien.NGAYSINH1 = reader.GetDateTime(3);
                            giaoVien.QUEQUAN1 = reader.GetString(4);
                            giaoVien.SODT1 = reader.GetString(5);

                            gv.Add(giaoVien);
                        }
                    }
                }
                conn.CloseConnection();
            }

            return gv;
        }

        public DataTable LoadGiaoVien1()
        {

            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "SELECT GiaoVien.MaGV as \"Mã Giáo Viên\", GiaoVien.HoGV as \"Họ\", GiaoVien.TenGV as \"Tên\", GiaoVien.NgaySinh as \"Ngày Sinh\", GiaoVien.QueQuan as \"Quê Quán\", GiaoVien.SoDT as \"Số Điện Thoại\" FROM GiaoVien";
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

        public List<GiaoVien_DTO> LoadGiaoVienTen(string t)
        {
            Connection conn = new Connection();
            List<GiaoVien_DTO> gv = new List<GiaoVien_DTO>();
            string sqlQuery = "SELECT * FROM GiaoVien WHERE TenGV LIKE '%" + t +"%'";
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GiaoVien_DTO giaoVien = new GiaoVien_DTO();
                            giaoVien.MAGV1 = reader.GetInt32(0);
                            giaoVien.HOGV1 = reader.GetString(1);
                            giaoVien.TENGV1 = reader.GetString(2);
                            giaoVien.NGAYSINH1 = reader.GetDateTime(3);
                            giaoVien.QUEQUAN1 = reader.GetString(4);
                            giaoVien.SODT1 = reader.GetString(5);

                            gv.Add(giaoVien);
                        }
                    }
                }
                conn.CloseConnection();
            }
            
            return gv;
        }

        public List<GiaoVien_DTO> LoadGiaoVienMa(int t)
        {
            Connection conn = new Connection();
            List<GiaoVien_DTO> gv = new List<GiaoVien_DTO>();
            string sqlQuery = "SELECT * FROM GiaoVien WHERE MaGV LIKE '%" + t + "%'";
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GiaoVien_DTO giaoVien = new GiaoVien_DTO();
                            giaoVien.MAGV1 = reader.GetInt32(0);
                            giaoVien.HOGV1 = reader.GetString(1);
                            giaoVien.TENGV1 = reader.GetString(2);
                            giaoVien.NGAYSINH1 = reader.GetDateTime(3);
                            giaoVien.QUEQUAN1 = reader.GetString(4);
                            giaoVien.SODT1 = reader.GetString(5);

                            gv.Add(giaoVien);
                        }
                    }
                }
                conn.CloseConnection();
            }

            return gv;
        }

        public bool addGiaoVien(GiaoVien_DTO g)
        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "INSERT INTO GiaoVien(MaGV, HoGV, TenGV, NgaySinh, QueQuan, SoDT) " +
                "VALUES(N'" + g.MAGV1 + "', N'" + g.HOGV1 + "',N'" + g.TENGV1 + "', '" + g.NGAYSINH1 + "',N'" + g.QUEQUAN1 + "', '" + g.SODT1 + "')";
            
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            try
            {
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }catch (Exception)
            {
                connection.Close();
                return false;
            }
            

        }

        public bool delGiaoVien(int id)
        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "DELETE FROM GiaoVien WHERE MaGV = " + id + " ";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            try
            {
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }catch(Exception)
            {
                connection.Close();
                return false;
            }
        }

        public bool updateGiaoVien(GiaoVien_DTO gv)
        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "UPDATE GiaoVien set HoGV = N'" + gv.HOGV1 + "', TenGV = N'" + gv.TENGV1 + "', NgaySinh = N'" + gv.NGAYSINH1 + "', QueQuan = N'" + gv.QUEQUAN1 + "',SoDT = N'" + gv.SODT1 + "' WHERE MaGV = '" + gv.MAGV1 + "'";
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