using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHotel.Model;
using System.Data;
using System.Windows.Forms;

namespace SistemaHotel.Control
{
    class CHabReserva
    {
        public static DataTable visualizar_habitacion_reserva()
        {
            MHabReserva entrada = new MHabReserva();
            return entrada.mostrar_las_habitaciones_reserva();
        }

        public static DataTable visualizar_tipo_habitacion()
        {
            MHabReserva entrada = new MHabReserva();
            return entrada.mostrar_tipo_habitacion();
        }

        public static DataTable visualizar_las_habitaciones()
        {
            MHabReserva entrada = new MHabReserva();
            return entrada.mostrar_las_habitaciones();
        }

        public static DataTable visualizar_la_reservacion()
        {
            MHabReserva entrada = new MHabReserva();
            return entrada.mostrar_la_reservacion();
        }
        
        public void insertar_datos(int idhabitacion,int idreserva,DateTime fechaentrada, DateTime fechasalida,double precio)
        {
            MHabReserva obj = new MHabReserva();
            obj.No_habitacion = idhabitacion;
            obj.Id_reserva = idreserva;
            obj.Fecha_entrada = fechaentrada;
            obj.Fecha_salida = fechasalida;
            obj.Precio = precio;
            obj.Insertar(obj);
        }


    }
}
