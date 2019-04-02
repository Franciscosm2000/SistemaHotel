using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHotel.Model;
using System.Data;

namespace SistemaHotel.Control
{
    class CReserva
    {
        //metodo para inserta los datos de la reserva
        public static string insertar_datos(int idcliente, int idempleado, string fechareserva,
            string formapago, string divisa, string stat)
        {
            MReserva obj = new MReserva();
            obj.Id_cliente = idcliente;
            obj.Id_empleado = idempleado;
            obj.Fecha_reserva = fechareserva;
            obj.Forma_pago = formapago;
            obj.Divisa = divisa;
            obj.Stat = stat;
            return obj.Insertar(obj);
        }

        public static DataTable listado_cliente()
        {
            return new MReserva().listado_cliente();
        }

        public static DataTable listado_empleado()
        {
            return new MReserva().listado_empleado();
        }

        public DataTable show()
        {
            MReserva reserva = new MReserva();
            return reserva.show();
        }

    }
}
