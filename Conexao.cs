using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fast9Pneus
{
    public class Conexao
    {
        public static SqlConnection getConnection()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3I5D8M1\SQLEXPRESS;Initial Catalog=fast9pneus;User ID=maarc;Password=233213; Initial Catalog = fast9pneus; Integrated Security = True");

            return con;
        }

        public static SqlDataReader getQuery(String query, SqlConnection con)
        {            
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader = null;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro " + ex.Message);
                throw;
            }

            return reader;
        }

        public static SqlCommand setQuery(String query, SqlConnection con)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro " + ex.Message);
                throw;

            }
            return cmd;
        }
    }
}
