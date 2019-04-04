using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHotel.Model;

namespace SistemaHotel.Control
{
    class CCliente
    {
        //Metodo que envia los datos de agregar ciente hasta Mcliente
        public void AgregarCliente(String p_n, String s_n, String p_a, String s_a, String tel, String direccion, String correo)
        {
            MCliente cliente = new MCliente(p_n, s_n, p_a, s_a, tel, direccion, correo);
            cliente.AgregarCliente(cliente);
        }
        public static DataTable show()
        {
            MCliente cliente = new MCliente();
            return cliente.show();
        }
        //Metodo que envia los datos a editar cilente hasta Mcliente
        public void EditarCliente(int id ,String p_n, String s_n, String p_a, String s_a, String tel, String direccion, String correo)
        {
            MCliente cliente = new MCliente(id,p_n, s_n, p_a, s_a, tel, direccion, correo);
            cliente.EditarCLiente(cliente);
        }

        //Metodo que envia la id a Cambiar estado en Mcliente

        public void CambiarEstado(int id)
        {
            MCliente cliente = new MCliente();
            cliente.CambiarEstado(id);
        }

        //Metodo Buscar
        public static DataTable showBusqueda(String bus)
        {
            MCliente cliente = new MCliente();
            return cliente.showBusqueda(bus);
        }
    }
}
