using System.Data.SqlClient;

namespace BookMS
{
    class Dao
    {
        SqlConnection sc;

        public SqlConnection connect()
        {
            string str = @"Server=localhost\SQLEXPRESS;Database=BookDB;Trusted_Connection=True";//数据库连接字符串

            sc = new SqlConnection(str);
            sc.Open();

            return sc;
        }

        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }

        public int Execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }

        public SqlDataReader read(string sql)//读取操作
        {
            return command(sql).ExecuteReader();
        }

        public void DaoClose()
        {
            sc.Close();
        }
    }
}
