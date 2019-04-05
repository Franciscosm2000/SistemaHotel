using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Model
{
    class MRec
    {
        public DataTable rec_hab(int m, int y)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConexionBD.DATABASE_URL;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "rec_hab";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@m", m);
                cmd.Parameters.AddWithValue("@yr", y);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(dt);

            }catch(Exception ex)
            {
                throw new Exception("Error de conexíon\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable rec_serv(int m, int y)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConexionBD.DATABASE_URL;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "rec_serv";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@m", m);
                cmd.Parameters.AddWithValue("@yr", y);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(dt);

            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexíon\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable bonif_empl(int m, int y)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConexionBD.DATABASE_URL;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "bonif_empl";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@m", m);
                cmd.Parameters.AddWithValue("@yr", y);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(dt);

            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexíon\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
