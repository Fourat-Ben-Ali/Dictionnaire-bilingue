using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_dictionnaire
{
    internal class connection_db
    {

        String connection = "Data Source=FOURAT\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand command;
        DataTable dt;

        public connection_db()
        {
            con = new SqlConnection(connection);
            dt = new DataTable();


        }
        public void open_connection()
        {
            con.Open();
        }
        public void close_connection()
        {
            con.Close();
        }

        public void execute_query(String query)
        {
            open_connection();
            command = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(command);

        }
        public void add_sql_value(string sql, string value)
        {
            command.Parameters.AddWithValue(sql, value);
        }
        public DataTable register()
        {
            adapter.Fill(dt);
            return dt;

        }
        public int table_rows()
        {

            return dt.Rows.Count;
        }
    }
}
