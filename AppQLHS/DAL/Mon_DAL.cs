
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mon_DAL
    {
        public List<Mon_DTO> getMon()
        {
            Connection conn = new Connection();
            List<Mon_DTO> m = new List<Mon_DTO>();
            string sqlQuery = "SELECT * FROM Mon";
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Mon_DTO mon = new Mon_DTO();
                            mon.MaMon = reader.GetInt32(0);
                            mon.TenMon = reader.GetString(1);
                            m.Add(mon);
                        }
                    }
                }
                conn.CloseConnection();
            }

            return m;
        }

        public List<Mon_DTO> getDMonByid(int id)
        {
            Connection conn = new Connection();
            List<Mon_DTO> m = new List<Mon_DTO>();
            string sqlQuery = "SELECT * FROM Mon Where MaMon like '%" + id + "%'";
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Mon_DTO mon = new Mon_DTO();
                            mon.MaMon = reader.GetInt32(0);
                            mon.TenMon = reader.GetString(1);
                            m.Add(mon);
                        }
                    }
                }
                conn.CloseConnection();
            }

            return m;
        }

        public List<Mon_DTO> getDMonByTen(string ten)
        {
            Connection conn = new Connection();
            List<Mon_DTO> m = new List<Mon_DTO>();
            string sqlQuery = "SELECT * FROM Mon Where TenMon like '%" + ten + "%'";
            using (SqlConnection connection = conn.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Mon_DTO mon = new Mon_DTO();
                            mon.MaMon = reader.GetInt32(0);
                            mon.TenMon = reader.GetString(1);
                            m.Add(mon);
                        }
                    }
                }
                conn.CloseConnection();
            }

            return m;
        }

        public bool addMon(Mon_DTO m)
        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "INSERT INTO Mon(MaMon, TenMon) " +
                "VALUES(N'" + m.MaMon + "', N'" + m.TenMon + "')";

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

        public bool delMon(int id)
        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "DELETE FROM Mon WHERE MaMon = " + id + " ";
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

        public bool updateMon(Mon_DTO m)

        {
            Connection conn = new Connection();
            SqlConnection connection = conn.OpenConnection();
            string sqlQuery = "UPDATE Mon set TenMon = N'" + m.TenMon + "' WHERE MaMon="+m.MaMon;
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
