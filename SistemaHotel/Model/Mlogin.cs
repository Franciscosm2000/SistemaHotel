using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Model
{
    class Mlogin
    {
        public String log_in(String usrname, String pswd)
        {
            String resp;
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConexionBD.DATABASE_URL;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "log_in";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usrname", usrname);
                cmd.Parameters.AddWithValue("@pswd", pswd);
                resp = cmd.ExecuteScalar() as String;
            }
            catch(Exception ex)
            {
                throw new Exception("Error de Conexión\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return resp;
        }
    }
}
