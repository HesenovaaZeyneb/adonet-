

using System.Xml.Linq;

namespace Adonet.Context
{
    internal class AppDbContext
    {
        string con = "server = USERHOME - PC82\\MSSQLSERVER11; database=Ab105;Trusted_Connection=true";
        SqlConnection sqlConnection;
        public AppDbContext()
        {
           sqlConnection = new SqlConnection(con);
        }
        public int NonQuery(string command)
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            int result = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
        }
        public DataTable GetTable(string query)
        {
            sqlConnection.Open();
            SqlDataAdapter adapter= new SqlDataAdapter(query,sqlConnection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqlConnection.Close();
            return dt;


        }


    }
}
