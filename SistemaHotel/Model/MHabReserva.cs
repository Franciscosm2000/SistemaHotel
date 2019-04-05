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
    class MHabReserva
    {
        private int id_habitacion_reserva;
        private int no_habitacion;
        private int id_reserva;
        private DateTime fecha_entrada;
        private DateTime fecha_salida;
        private double precio;

        public MHabReserva(int no_habitacion, int id_reserva, DateTime fecha_entrada, DateTime fecha_salida, double precio)
        {
            this.No_habitacion = no_habitacion;
            this.Id_reserva = id_reserva;
            this.Fecha_entrada = fecha_entrada;
            this.Fecha_salida = fecha_salida;
            this.Precio = precio;
        }
        public MHabReserva() { }

        public int Id_habitacion_reserva { get => id_habitacion_reserva; set => id_habitacion_reserva = value; }
        public int No_habitacion { get => no_habitacion; set => no_habitacion = value; }
        public int Id_reserva { get => id_reserva; set => id_reserva = value; }
        public DateTime Fecha_entrada { get => fecha_entrada; set => fecha_entrada = value; }
        public DateTime Fecha_salida { get => fecha_salida; set => fecha_salida = value; }
        public double Precio { get => precio; set => precio = value; }

        public DataTable mostrar_las_habitaciones_reserva()
        {
            DataTable visual = new DataTable();
            SqlConnection cone = new SqlConnection();
            try
            {
                cone.ConnectionString = ConexionBD.DATABASE_URL;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cone;
                cmd.CommandText = "mostrar_habitacion_reserva";
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
        
        public DataTable mostrar_tipo_habitacion()
        {
            DataTable visual = new DataTable();
            SqlConnection cone = new SqlConnection();
            try
            {
                cone.ConnectionString = ConexionBD.DATABASE_URL;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cone;
                cmd.CommandText = "mostrar_tipo_habitacion";
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

        public DataTable mostrar_las_habitaciones()
        {
            DataTable visual = new DataTable();
            SqlConnection cone = new SqlConnection();
            try
            {
                cone.ConnectionString = ConexionBD.DATABASE_URL;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cone;
                cmd.CommandText = "mostrar_habitaciones";
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

        public DataTable mostrar_la_reservacion()
        {
            DataTable visual = new DataTable();
            SqlConnection cone = new SqlConnection();
            try
            {
                cone.ConnectionString = ConexionBD.DATABASE_URL;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cone;
                cmd.CommandText = "mostrar_la_reservacion";
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

        public string Insertar(MHabReserva habreserva)
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
                SqlCmd.CommandText = "insertar_habitacion_reserva";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter nohabitacion = new SqlParameter();
                nohabitacion.ParameterName = "@no_habitacion";
                nohabitacion.SqlDbType = SqlDbType.Int;
                //idcliente.Size = 60;
                nohabitacion.Value = habreserva.No_habitacion;
                SqlCmd.Parameters.Add(nohabitacion);

                SqlParameter idreserva = new SqlParameter();
                idreserva.ParameterName = "@id_reserva";
                idreserva.SqlDbType = SqlDbType.Int;
                //idempleado.Size = 60;
                idreserva.Value = habreserva.Id_reserva;
                SqlCmd.Parameters.Add(idreserva);

                SqlParameter fechaentrada = new SqlParameter();
                fechaentrada.ParameterName = "@fecha_entrada";
                fechaentrada.SqlDbType = SqlDbType.Date;
                //fechareserva.Size = 60;
                fechaentrada.Value = habreserva.Fecha_entrada;
                SqlCmd.Parameters.Add(fechaentrada);

                SqlParameter fechasalida = new SqlParameter();
                fechasalida.ParameterName = "@fecha_salida";
                fechasalida.SqlDbType = SqlDbType.Date;
                //fechareserva.Size = 60;
                fechasalida.Value = habreserva.Fecha_salida;
                SqlCmd.Parameters.Add(fechasalida);

                SqlParameter precio = new SqlParameter();
                precio.ParameterName = "@precio";
                precio.SqlDbType = SqlDbType.Money;
                //stat.Size = 15;
                precio.Value = habreserva.Precio;
                SqlCmd.Parameters.Add(precio);


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

        public DataTable EliminarHabReserva(int idhabreserva)
        {
            DataTable DtResultado = new DataTable("Habitacion Reserva");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = ConexionBD.DATABASE_URL;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "eliminar_un_id_de_ha_reserva";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter habreserva = new SqlParameter();
                habreserva.ParameterName = "@id_hab_reserva";
                habreserva.SqlDbType = SqlDbType.Int;
                //nombrecliente.Size = 20;
                habreserva.Value = idhabreserva;
                SqlCmd.Parameters.Add(habreserva);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
    }
}
