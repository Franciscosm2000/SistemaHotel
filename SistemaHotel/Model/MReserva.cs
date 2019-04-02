using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHotel.Control;
using System.Data.SqlClient;
using System.Data;

namespace SistemaHotel.Model
{
    class MReserva
    {
        private int id_cliente;
        private int id_empleado;
        private string fecha_reserva;
        private string forma_pago;
        private string divisa;
        private string stat;

        public MReserva(int id_cliente, int id_empleado, string fecha_reserva, string forma_pago, string divisa, string stat)
        {
            this.Id_cliente = id_cliente;
            this.Id_empleado = id_empleado;
            this.Fecha_reserva = fecha_reserva;
            this.Forma_pago = forma_pago;
            this.Divisa = divisa;
            this.Stat = stat;
        }

        public MReserva() { }

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public string Fecha_reserva { get => fecha_reserva; set => fecha_reserva = value; }
        public string Forma_pago { get => forma_pago; set => forma_pago = value; }
        public string Divisa { get => divisa; set => divisa = value; }
        public string Stat { get => stat; set => stat = value; }

        public DataTable listado_cliente()
        {
            DataTable DtResultado = new DataTable("Listado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = ConexionBD.DATABASE_URL;
                SqlCon.Open();

                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "listado_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);

                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable listado_empleado()
        {
            DataTable DtResultado = new DataTable("Listado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = ConexionBD.DATABASE_URL;
                SqlCon.Open();

                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "listado_empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);

                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        public string Insertar(MReserva reserva)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = ConexionBD.DATABASE_URL;
                SqlCon.Open();
                
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "insertar_reserva";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter idcliente = new SqlParameter();
                idcliente.ParameterName = "@id_cliente";
                idcliente.SqlDbType = SqlDbType.Int;
                //idcliente.Size = 60;
                idcliente.Value = reserva.Id_cliente;
                SqlCmd.Parameters.Add(idcliente);

                SqlParameter idempleado = new SqlParameter();
                idempleado.ParameterName = "@id_empleado";
                idempleado.SqlDbType = SqlDbType.Int;
                //idempleado.Size = 60;
                idempleado.Value = reserva.Id_empleado;
                SqlCmd.Parameters.Add(idempleado);

                SqlParameter fechareserva = new SqlParameter();
                fechareserva.ParameterName = "@fecha_reserva";
                fechareserva.SqlDbType = SqlDbType.VarChar;
                fechareserva.Size = 60;
                fechareserva.Value = reserva.Fecha_reserva;
                SqlCmd.Parameters.Add(fechareserva);

                SqlParameter formapago = new SqlParameter();
                formapago.ParameterName = "@forma_pago";
                formapago.SqlDbType = SqlDbType.VarChar;
                formapago.Size = 60;
                formapago.Value = reserva.Forma_pago;
                SqlCmd.Parameters.Add(formapago);

                SqlParameter divisa = new SqlParameter();
                divisa.ParameterName = "@divisa";
                divisa.SqlDbType = SqlDbType.VarChar;
                divisa.Size = 60;
                divisa.Value = reserva.Divisa;
                SqlCmd.Parameters.Add(divisa);

                SqlParameter stat = new SqlParameter();
                stat.ParameterName = "@stat";
                stat.SqlDbType = SqlDbType.VarChar;
                stat.Size = 60;
                stat.Value = reserva.Stat;
                SqlCmd.Parameters.Add(stat);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public DataTable show()
        {
            DataTable visual = new DataTable();
            SqlConnection cone = new SqlConnection();
            try
            {
                cone.ConnectionString = ConexionBD.DATABASE_URL;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cone;
                cmd.CommandText = "mostrar_reserva";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(visual);

            }
            catch (Exception)
            {
                throw new Exception("Error en la conexion");
            }
            return visual;
        }


    }
}