using System.Data;
using System.Data.SqlClient;

namespace RodWpf
{
    public class DatabaseConnection
    {
        public DataTable QuerySelect(string sql_string)     //SELECT    Pobiera z Bazy 
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.PolaczenieBaza);
            SqlDataAdapter sda = new SqlDataAdapter(sql_string, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }   

        public void Query(string sql_string)    //  Na razie niepotrzebne
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.PolaczenieBaza);
            
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql_string;
            cmd.Connection = con;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }   

        public int QueryInsert(string sql_string)   //INSERT INTO   Dopisuje wiersz do tabeli, zwraca id dodanego wiersza.
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.PolaczenieBaza);

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql_string;
            cmd.Connection = con;

            con.Open();
            var reader = cmd.ExecuteReader();
            reader.Read();
            int roomId = reader.GetInt32(0);
            con.Close();
            
            return roomId;
        }


    }
}
