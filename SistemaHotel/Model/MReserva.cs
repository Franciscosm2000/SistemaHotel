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
        private int id_reserva;
        private int id_cliente;
        private int id_empleado;
        private DateTime fecha_reserva;
        private string forma_pago;
        private string divisa;
        private string stat;



        public MReserva(int id_cliente, int id_empleado, DateTime fecha_reserva, string forma_pago, string divisa, string stat)
        {
            this.Id_cliente = id_cliente;
            this.Id_empleado = id_empleado;
            this.Fecha_reserva = fecha_reserva;
            this.Forma_pago = forma_pago;
            this.Divisa = divisa;
            this.Stat = stat;
        }

        public int Id_reserva { get => id_reserva; set => id_reserva = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public DateTime Fecha_reserva { get => fecha_reserva; set => fecha_reserva = value; }
        public string Forma_pago { get => forma_pago; set => forma_pago = value; }
        public string Divisa { get => divisa; set => divisa = value; }
        public string Stat { get => stat; set => stat = value; }

        public MReserva() { }


        public DataTable mostrar_los_clientes()
        {
            DataTable visual = new DataTable();
            SqlConnection cone = new SqlConnection();
            try
            {
                cone.ConnectionString = ConexionBD.DATABASE_URL;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cone;
                cmd.CommandText = "clientes";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(visual);

            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion\n" + ex.Message);
            }
            return visual;
        }

        public DataTable mostrar_los_empleados()
        {
            DataTable visual = new DataTable();
            SqlConnection cone = new SqlConnection();
            try
            {
                cone.ConnectionString = ConexionBD.DATABASE_URL;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cone;
                cmd.CommandText = "empleados";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(visual);

            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion\n" + ex.Message);
            }
            return visual;
        }


        //llamando al proceso almacenado de mostrar reserva
        public DataTable mostrar_reserva()
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
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion\n" + ex.Message);
            }
            return visual;
        }

        //lamando al proceso almacenado de insertar reserva
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
                fechareserva.SqlDbType = SqlDbType.Date;
                //fechareserva.Size = 60;
                fechareserva.Value = reserva.Fecha_reserva;
                SqlCmd.Parameters.Add(fechareserva);

                SqlParameter formapago = new SqlParameter();
                formapago.ParameterName = "@forma_pago";
                formapago.SqlDbType = SqlDbType.VarChar;
                formapago.Size = 15;
                formapago.Value = reserva.Forma_pago;
                SqlCmd.Parameters.Add(formapago);

                SqlParameter divisa = new SqlParameter();
                divisa.ParameterName = "@divisa";
                divisa.SqlDbType = SqlDbType.VarChar;
                divisa.Size = 3;
                divisa.Value = reserva.Divisa;
                SqlCmd.Parameters.Add(divisa);

                SqlParameter stat = new SqlParameter();
                stat.ParameterName = "@stat";
                stat.SqlDbType = SqlDbType.VarChar;
                stat.Size = 15;
                stat.Value = reserva.Stat;
                SqlCmd.Parameters.Add(stat);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso la reserva";

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

    }
}