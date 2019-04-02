using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Model
{
    class MHabs
    {
        public DataTable habs_en_fechas(DateTime f_in, DateTime f_out)
        {
            DataTable res = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConexionBD.DATABASE_URL;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "disponibilidad_hab";

                SqlParameter par_f_in = new SqlParameter();
                par_f_in.ParameterName = "@f_in";
                par_f_in.DbType = DbType.Date;
                par_f_in.Value = f_in;
                cmd.Parameters.Add(par_f_in);

                SqlParameter par_f_out = new SqlParameter();
                par_f_out.ParameterName = "@f_out";
                par_f_out.DbType = DbType.Date;
                par_f_out.Value = f_out;
                cmd.Parameters.Add(par_f_out);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(res);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Error de Conexión");
            }
            return res;
        }
    }
}
