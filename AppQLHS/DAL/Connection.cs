using System.Data.SqlClient;

namespace DAL
{
    public class Connection
    {
        private static SqlConnection connection;
        private string connectionString;

        public Connection()
        {
            // Thay đổi chuỗi kết nối này để phù hợp với cơ sở dữ liệu của bạn
            connectionString = @"Data Source=LAPTOP-HH0VDAPF;Initial Catalog=QLHS;Integrated Security=True;User ID=;Password=";

            connection = new SqlConnection(connectionString);
        }
        public SqlConnection OpenConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}