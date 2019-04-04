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
        public static DataTable visualizar()
        {
            MReserva entrada = new MReserva();
            return entrada.mostrar_reserva();

        }

        public static DataTable visualizar_2()
        {
            MReserva entrada = new MReserva();
            return entrada.mostrar_los_clientes();
        }

        public static DataTable visualizar_3()
        {
            MReserva entrada = new MReserva();
            return entrada.mostrar_los_empleados();
        }
        
        //metodo para inserta los datos de la reserva
        public void insertar_datos(int idcliente, int idempleado, DateTime fechareserva,
            string formapago, string divisa, string stat)
        {
            MReserva obj = new MReserva();
            obj.Id_cliente = idcliente;
            obj.Id_empleado = idempleado;
            obj.Fecha_reserva = fechareserva;
            obj.Forma_pago = formapago;
            obj.Divisa = divisa;
            obj.Stat = stat;
            obj.Insertar(obj);
            
        }

        public void editar_datos(int idreserva,int idcliente, int idempleado, DateTime fechareserva,
            string formapago, string divisa, string stat)
        {
            MReserva obj = new MReserva();
            obj.Id_reserva = idreserva;
            obj.Id_cliente = idcliente;
            obj.Id_empleado = idempleado;
            obj.Fecha_reserva = fechareserva;
            obj.Forma_pago = formapago;
            obj.Divisa = divisa;
            obj.Stat = stat;
            obj.Editar(obj);

        }

        public static DataTable buscar_cliente(string busquedacliente)
        {
            MReserva entrada = new MReserva();
            return entrada.BuscarCliente(busquedacliente);
        }

        public static DataTable eliminar_reserva(int idreserva)
        {
            MReserva entrada = new MReserva();
            return entrada.EliminarReserva(idreserva);
        }
    }
}
